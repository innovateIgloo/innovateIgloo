

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ�洢���͵����������
    /// </summary>
    public class SetBucketStoragePolicyRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketStoragePolicy";
        }

        /// <summary>
        ///  Ͱ�Ĵ洢���͡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public StorageClassEnum? StorageClass
        {
            get;
            set;
        }

    }
}
    
