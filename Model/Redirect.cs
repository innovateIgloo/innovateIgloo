
namespace OBS.Model
{
    /// <summary>
    /// �ض������á�
    /// </summary>
    public class Redirect : RedirectBasic
    {

        /// <summary>
        /// HTTP״̬�����á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string HttpRedirectCode
        {
            get;
            set;
        }



        /// <summary>
        /// �ض�������ʱʹ�õĶ�����ǰ׺��  
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ReplaceKeyPrefixWith
        {
            get;
            set;
        }



        /// <summary>
        /// �ض�������ʱʹ�õĶ�������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��������ReplaceKeyPrefixWithͬʱ���ڡ�
        /// </para>
        /// </remarks>
        public string ReplaceKeyWith
        {
            get;
            set;
        }


    }
}
