

namespace OBS.Model
{
    /// <summary>
    /// ����ͰWebsite���йܣ����õ����������
    /// </summary>
    public class SetBucketWebsiteRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketWebsite";
        }

        /// <summary>
        /// Ͱ��Website���йܣ����á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public WebsiteConfiguration Configuration
        {
            get;
            set;
        }

    }
}
    
