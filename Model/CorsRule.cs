
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ�Ŀ�����Դ�������CORS����
    /// </summary>
    public class CorsRule
    {
        private IList<HttpVerb> allowedMethods;
        private IList<string> allowedOrigins;
        private IList<string> exposeHeaders;
        private IList<string> allowedHeaders;

        /// <summary>
        /// �������������ķ����б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<HttpVerb> AllowedMethods
        {
            get {
                
                return this.allowedMethods ?? (this.allowedMethods = new List<HttpVerb>()); }
            set { this.allowedMethods = value; }
        }

        /// <summary>
        /// ��������������������Դ�б���ʾ�������ַ�������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<string> AllowedOrigins
        {
            get {
                
                return this.allowedOrigins ?? (this.allowedOrigins = new List<string>()); }
            set { this.allowedOrigins = value; }
        }

        /// <summary>
        /// �������ID��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// �ɲ�����255���ַ����ַ�����ɡ�
        /// </para>
        /// </remarks>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// �������������Ӧ�пɷ��ص�ͷ���б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<string> ExposeHeaders
        {
            get {
                
                return this.exposeHeaders ?? (this.exposeHeaders = new List<string>()); }
            set { this.exposeHeaders = value; }
        }

        /// <summary>
        /// �ͻ��˶��������Ļ���ʱ�䣬����Ϊ��λ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public int? MaxAgeSeconds
        {
            get;
            set;
        }


        /// <summary>
        /// ������������������п�Я����ͷ���б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public IList<string> AllowedHeaders
        {
            get {
               
                return this.allowedHeaders ?? (this.allowedHeaders = new List<string>()); }
            set { this.allowedHeaders = value; }
        }

    }
}
