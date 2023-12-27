
using System;
using System.Collections.Generic;
namespace OBS.Model
{
    /// <summary>
    /// POST����Ȩ��������� 
    /// </summary>
    public class CreatePostSignatureRequest : ObsBucketWebServiceRequest
    {

        private IDictionary<string, string> parameters;

        internal override string GetAction()
        {
            return "CreatePostSignature";
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
        /// ����ʱ�䡣
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public DateTime? Expires
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
        public IDictionary<String, String> FormParameters
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