
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ����Ϣ֪ͨ���á�
    /// </summary>
    public class NotificationConfiguration
    {

        private IList<TopicConfiguration> topicConfigurations;

        private IList<FunctionGraphConfiguration> functionGraphConfigurations;

        /// <summary>
        /// �¼�֪ͨ�����б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<TopicConfiguration> TopicConfigurations
        {
            get
            {
                
                return this.topicConfigurations ?? (this.topicConfigurations = new List<TopicConfiguration>());
            }
            set { this.topicConfigurations = value; }
        }

        /// <summary>
        /// �������������������б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<FunctionGraphConfiguration> FunctionGraphConfigurations
        {
            get
            {

                return this.functionGraphConfigurations ?? (this.functionGraphConfigurations = new List<FunctionGraphConfiguration>());
            }
            set { this.functionGraphConfigurations = value; }
        }
    }
}
