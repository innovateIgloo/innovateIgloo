
namespace OBS.Model
{
    /// <summary>
    /// �����ض������
    /// </summary>
    public class RoutingRule
    {
        /// <summary>
        /// �����ض���������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public Condition Condition
        {
            get;
            set;
        }


        /// <summary>
        /// �����ض������á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public Redirect Redirect
        {
            get;
            set;
        }

    }
}
