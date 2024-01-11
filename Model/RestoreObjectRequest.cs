
namespace OBS.Model
{
    /// <summary>
    /// ȡ�ع鵵�洢��������������
    /// </summary>
    public class RestoreObjectRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "RestoreObject";
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ObjectKey
        {
            get;
            set;
        }

        /// <summary>
        /// ȡ�ض���ı���ʱ�䡣
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public int Days
        {
            get;
            set;
        }

        /// <summary>
        /// ����汾�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string VersionId
        {
            get;
            set;
        }


        /// <summary>
        /// ȡ��ѡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public RestoreTierEnum? Tier
        {
            get;
            set;
        }

    }
}    
