
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OBS.Model
{
    /// <summary>
    /// ����ɾ����������������
    /// </summary>
    public partial class DeleteObjectsRequest : ObsBucketWebServiceRequest
    {
        private IList<KeyVersion> objects;

        internal override string GetAction()
        {
            return "DeleteObjects";
        }

        /// <summary>
        /// ��ɾ���Ķ����б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<KeyVersion> Objects
        {
            get 
            {
                return this.objects ?? (this.objects = new List<KeyVersion>()); 
            }
            set { this.objects = value; }
        }

        /// <summary>
        /// ����ɾ���������Ӧģʽ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��Ϊfalseʱʹ��verboseģʽ, Ϊtrueʱʹ��quietģʽ��Ĭ��Ϊverboseģʽ��
        /// </para>
        /// </remarks>
        public bool? Quiet
        {
            get;
            set;
        }

    }
}
    
