
namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�б�����������
    /// </summary>
    public class ListBucketsRequest : ObsWebServiceRequest
    {
        private bool queryLocation = true;
        /// <summary>
        /// �Ƿ��г�����Ͱ��������Ϣ��Ĭ��Ϊtrue��
        /// </summary>
        public bool IsQueryLocation
        {
            get
            {
                return this.queryLocation;
            }
            set
            {
                this.queryLocation = value;
            }
        }

        internal override string GetAction()
        {
            return "ListBuckets";
        }

    }
}
    
