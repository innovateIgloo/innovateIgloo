

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ��汾���õ���Ӧ�����
    /// </summary>
    public class GetBucketVersioningResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ�Ķ�汾���á�
        /// </summary>
        public VersioningConfiguration Configuration
        {
            get;
            internal set;
        }
    }
}
    
