

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ����Ȩ�޵����������
    /// </summary>
    public class SetBucketAclRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketAcl";
        }

        /// <summary>
        /// Ԥ������ʲ��ԡ�  
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public CannedAclEnum? CannedAcl
        {
            get;
            set;
        }


        /// <summary>
        /// ����Ȩ�ߺͷ���Ȩ���б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public AccessControlList AccessControlList
        {
            get;
            set;
        }

    }
}
    
