
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ��Website���йܣ����á�
    /// </summary>
    public class WebsiteConfiguration
    {

        private IList<RoutingRule> routingRules;
        /// <summary>
        /// �йܴ���ҳ�档
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ErrorDocument
        {
            get;
            set;
        }

        /// <summary>
        /// �й���ҳ��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ,���ֶα�׷���ڶ��ļ��е������ĩβ�����磺���õ��ǡ�index.html����������ǡ�samplebucket/images/����
        /// ���ص����ݽ��ǡ�samplebucket��Ͱ����Ϊ��images/index.html���Ķ�������ݣ������ֶβ���Ϊ�ջ��߰�����/���ַ���
        /// </para>
        /// </remarks>
        public string IndexDocument
        {
            get;
            set;
        }

        /// <summary>
        ///���������ض������á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public RedirectBasic RedirectAllRequestsTo
        {
            get;
            set;
        }

        /// <summary>
        /// �����ض�������б�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ����ErrorDocument��IndexDocument���ʹ�ã�������RedirectAllRequestsToһ��ʹ�á�
        /// </para>
        /// </remarks>
        public IList<RoutingRule> RoutingRules
        {
            get {
                
                return this.routingRules ?? (this.routingRules = new List<RoutingRule>()); }
            set { this.routingRules = value; }
        }

    }
}
