
namespace OBS.Model
{
    /// <summary>
    /// Ͱ��ǩ��
    /// </summary>
    public class Tag
    {
        

        /// <summary>
        /// ��ǩ���� 
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ���36���ַ������԰�����A-Z��a-z��0-9����-������_���Լ�Unicode(\u4E00-\u9FFF)��ͬһ��Ͱ��Tag��Key�����ظ���
        /// </para>
        /// </remarks>
        public string Key
        {
            get;
            set;
        }

        /// <summary>
        /// ��ǩֵ�� 
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ���ֵΪ43���ַ������԰�����A-Z��a-z��0-9����-������_������.���Լ�Unicode(\u4E00-\u9FFF)��
        /// </para>
        /// </remarks>
        public string Value
        {
            get;
            set;
        }

    }
}
