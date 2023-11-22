
using System;
using System.Collections.Generic;
namespace OBS.Model
{
    /// <summary>
    /// ��ʱ��Ȩ��������� 
    /// </summary>
    public class CreateTemporarySignatureRequest : ObsBucketWebServiceRequest
    {

        private IDictionary<string, string> headers;
        private MetadataCollection metadataCollection;
        private IDictionary<string, string> parameters;

        internal override string GetAction()
        {
            return "CreateTemporarySignature";
        }

        /// <summary>
        /// Ͱ����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public override string BucketName
        {
            get;
            set;
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
        /// ����ʱ�䣬��λ�롣
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public long? Expires
        {
            get;
            set;
        }



        /// <summary>
        /// ���󷽷���
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public HttpVerb Method
        {
            get;
            set;
        }


        /// <summary>
        /// ����ͷ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IDictionary<string, string> Headers
        {
            get
            {
                return this.headers ?? (this.headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase));
            }
            internal set
            {
                this.headers = value;
            }
        }


        /// <summary>
        /// �Զ���Ԫ���ݣ������ϴ����󡢳�ʼ���ֶ��ϴ����񡢸��ƶ���ʱ���á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public MetadataCollection Metadata
        {
            get
            {
              
                return this.metadataCollection ?? (this.metadataCollection = new MetadataCollection());
            }
            internal set
            {
                this.metadataCollection = value;
            }
        }

        /// <summary>
        /// ����Դ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public SubResourceEnum? SubResource
        {
            get;
            set;
        }

        /// <summary>
        /// �����ѯ������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IDictionary<String, String> Parameters
        {
            get {
     
                return this.parameters ?? (this.parameters = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase));
            }
            set
            {
                this.parameters = value;
            }
        }


    }
}