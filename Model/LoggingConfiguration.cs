
using System.Collections.Generic;


namespace OBS.Model
{
    /// <summary>
    /// Ͱ�ķ�����־���á�
    /// </summary>
    public class LoggingConfiguration : AbstractAccessControlList
    {
        

        /// <summary>
        /// ������־��Ŀ��Ͱ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string TargetBucketName { get; set; }

        /// <summary>
        /// ��Ŀ��Ͱ��������־����Ķ�����ǰ׺��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string TargetPrefix { get; set; }

        /// <summary>
        /// ί������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Agency
        {
            get;
            set;
        }

    }
}
