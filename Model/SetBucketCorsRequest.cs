

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ������Դ�������õ����������
    /// </summary>
    public class SetBucketCorsRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketCors";
        }

        /// <summary>
        /// Ͱ�Ŀ�����Դ�������á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public CorsConfiguration Configuration
        {
            get;
            set;
        }

    }
}
    
