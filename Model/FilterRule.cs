
namespace OBS.Model
{
    /// <summary>
    /// �¼�֪ͨ���õĹ��˹���
    /// </summary>
    public class FilterRule
    {


        /// <summary>
        /// ����������ǰ׺���׺���й��˱�ʶ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public FilterNameEnum? Name
        {
            get;
            set;
        }

        /// <summary>
        /// �������ؼ��֡� 
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Value
        {
            get;
            set;
        }

    }
}
