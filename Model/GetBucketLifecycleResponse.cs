

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�����������õ���Ӧ�����
    /// </summary>
    public class GetBucketLifecycleResponse : ObsWebServiceResponse
    {


        /// <summary>
        /// Ͱ�������������á�
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get;
            internal set;
        }
    }
}
    
