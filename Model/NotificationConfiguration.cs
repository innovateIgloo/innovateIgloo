
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ����Ϣ֪ͨ���á�
    /// </summary>
    public class NotificationConfiguration
    {

        private IList<TopicConfiguration> topicConfigurations;

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
    }
}
