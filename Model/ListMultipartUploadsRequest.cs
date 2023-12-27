


namespace OBS.Model
{
    /// <summary>
    /// �оٷֶ��ϴ���������������
    /// </summary>
    public class ListMultipartUploadsRequest : ObsBucketWebServiceRequest
    {


        internal override string GetAction()
        {
            return "ListMultipartUploads";
        }

        /// <summary>
        /// ���������з�����ַ���
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ���ڶ������а���Delimiter������������������������ָ����Prefix����˴��Ķ�������Ҫȥ��Prefix��
        /// �д����ַ�����һ��Delimiter֮����ַ�������Ϊһ�����鲢��ΪCommonPrefix���ء�
        /// </para>
        /// </remarks>
        public string Delimiter
        {
            get;
            set;
        }



        /// <summary>
        /// �оٷֶ��ϴ��������ʼλ�ã������������򣩡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string KeyMarker
        {
            get;
            set;
        }



        /// <summary>
        /// �оٷֶ��ϴ�����������Ŀ��  
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// ȡֵ��ΧΪ1~1000����������Χʱ������Ĭ�ϵ�1000���д���
        /// </para>
        /// </remarks>
        public int? MaxUploads
        {
            get;
            set;
        }



        /// <summary>
        /// �оٷֶ��ϴ�����Ķ�����ǰ׺��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Prefix
        {
            get;
            set;
        }



        /// <summary>
        /// �оٷֶ��ϴ��������ʼλ�ã����ֶ��ϴ������ID�����򣩡�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��ֻ����KeyMarker����һ��ʹ��ʱ�������壬����ָ�����ؽ������ʼλ�á�
        /// </para>
        /// </remarks>
        public string UploadIdMarker
        {
            get;
            set;
        }

    }
}
    
