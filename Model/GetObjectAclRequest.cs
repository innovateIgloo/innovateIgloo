

namespace OBS.Model
{
    /// <summary>
    /// ��ȡ�������Ȩ�޵����������
    /// </summary>
    public class GetObjectAclRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetObjectAcl";
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ObjectKey { get; set; }

        /// <summary>
        /// ����汾�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string VersionId { get; set; }


    }
}
    
