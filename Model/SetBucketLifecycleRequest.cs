

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ�����������õ����������
    /// </summary>
    public class SetBucketLifecycleRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketLifecycle";
        }

        /// <summary>
        /// Ͱ�������������á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public LifecycleConfiguration Configuration
        {
            get;
            set;
        }

    }
}
    
