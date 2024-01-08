using System.Numerics;
using static Assets.Enumerations;

namespace FacadePattern
{
    public class RobotArmFacade
    {
        /*We have private instances of the three APIs in the façade itself.
        It will be the job of the façade class to pass instructions through to the correct API in the correct format.*/
        private readonly WelderAttachmentApi _welderApi;
        private readonly BufferAttachmentApi _bufferApi;
        private readonly GrabberAttachementApi _grabberApi;
        public RobotArmAttachmentTypes CurrentAttachment;

        public RobotArmFacade(WelderAttachmentApi welderApi, BufferAttachmentApi bufferApi, GrabberAttachementApi grabberApi)
        {
            _welderApi = welderApi;
            _bufferApi = bufferApi;
            _grabberApi = grabberApi;

            // set to default as welder.
            CurrentAttachment = RobotArmAttachmentTypes.Welder;
        }

        //expose the method for activating the current attachment.
        public void Actuate()//Actuate: cause (a machine or device) to operate
        {
            switch (CurrentAttachment)
            {
                case RobotArmAttachmentTypes.Buffer:
                    _bufferApi.Buff();
                    break;
                case RobotArmAttachmentTypes.Grabber:
                    _grabberApi.Grab();
                    break;
                case RobotArmAttachmentTypes.Welder:
                    _welderApi.Weld();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void MoveTo(Quaternion quaternion)
        {
            //convert the single numbers in the quaternion into integers by rounding.
            var roundX = (int)Math.Round(quaternion.X, 0);
            var roundY = (int)Math.Round(quaternion.Y, 0);
            var roundZ = (int)Math.Round(quaternion.Z, 0);

            switch (CurrentAttachment)
            {
                case RobotArmAttachmentTypes.Buffer:
                    _bufferApi.Position(quaternion);//The buffer attachment requires a quaternion.
                    break;
                case RobotArmAttachmentTypes.Welder:
                    _welderApi.MoveTo(roundX, roundY, roundZ);
                    break;
                case RobotArmAttachmentTypes.Grabber:
                    _grabberApi.SetLocation(roundX, roundY);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
/*public void MoveTo(Quaternion quaternion)
 The obvious solution is to pick the most complicated requirement, Quaternion. Quaternions are 
part of the .NET System.Numerics library. This struct holds four values, W, X, Y, and Z of the 
Single type per the documentation. Since it is the most complicated requirement, it can be made 
to service the simpler method signatures by ignoring the parts of the quaternion we don’t need*/