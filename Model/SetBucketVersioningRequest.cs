

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ��汾���õ����������
    /// </summary>
    public class SetBucketVersioningRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketVersioning";
        }

        /// <summary>
        /// Ͱ�Ķ�汾���á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public VersioningConfiguration Configuration
        {
            get;
            set;
        }

    }
}
    
