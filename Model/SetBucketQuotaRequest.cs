

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ�������������
    /// </summary>
    public class SetBucketQuotaRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketQuota";
        }

        /// <summary>
        /// ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��Ϊ�ַ������ͣ���Ҫ������ֵת��Ϊ�ַ�����
        /// ��λΪ�ֽڣ�֧�ֵ����ֵΪ2^63 - 1���ַ�����ʽ�����ֵ��Ϊ��0����ʾͰ�����û�����ޡ�
        /// </para>
        /// </remarks>
        public long StorageQuota
        {
            get;
            set;
        }

    }
}
    
