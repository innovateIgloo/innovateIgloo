

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰWebsite���йܣ����õ���Ӧ�����
    /// </summary>
    public class GetBucketWebsiteResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ͱ��Website���йܣ����á�
        /// </summary>
        public WebsiteConfiguration Configuration
        {
            get;
            internal set;
        }

    }
}
    
