
namespace OBS.Model
{
    /// <summary>
    /// �����������ù���
    /// </summary>
    public class ReplicationRule
    {


        /// <summary>
        ///  ����ID���ɲ�����255���ַ����ַ�����ɡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// ������ƥ��Ķ�����ǰ׺��  
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ�����Ա�ʶ��Щ�������ƥ�䵽��ǰ�������򡣿�Ϊ���ַ���������ƥ��Ͱ�����ж���
        /// </para>
        /// </remarks>
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>
        /// ����״̬��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public RuleStatusEnum Status
        {
            get;
            set;
        }

        /// <summary>
        /// Ŀ��Ͱ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string TargetBucketName
        {
            get;
            set;
        }

        /// <summary>
        /// ����Ĵ洢���͡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public StorageClassEnum? TargetStorageClass
        {
            get;
            set;
        }

    }
}
