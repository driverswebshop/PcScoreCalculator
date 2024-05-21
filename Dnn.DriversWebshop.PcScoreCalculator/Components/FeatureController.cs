/*
' Copyright (c) 2024 Daniel Damjan
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace DriversWebshop.Dnn.Dnn.DriversWebshop.PcScoreCalculator.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.DriversWebshop.PcScoreCalculator
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.DriversWebshop.PcScoreCalculatorInfo> colDnn.DriversWebshop.PcScoreCalculators = GetDnn.DriversWebshop.PcScoreCalculators(ModuleID);
        //if (colDnn.DriversWebshop.PcScoreCalculators.Count != 0)
        //{
        //    strXML += "<Dnn.DriversWebshop.PcScoreCalculators>";

        //    foreach (Dnn.DriversWebshop.PcScoreCalculatorInfo objDnn.DriversWebshop.PcScoreCalculator in colDnn.DriversWebshop.PcScoreCalculators)
        //    {
        //        strXML += "<Dnn.DriversWebshop.PcScoreCalculator>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.DriversWebshop.PcScoreCalculator.Content) + "</content>";
        //        strXML += "</Dnn.DriversWebshop.PcScoreCalculator>";
        //    }
        //    strXML += "</Dnn.DriversWebshop.PcScoreCalculators>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.DriversWebshop.PcScoreCalculators = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.DriversWebshop.PcScoreCalculators");
        //foreach (XmlNode xmlDnn.DriversWebshop.PcScoreCalculator in xmlDnn.DriversWebshop.PcScoreCalculators.SelectNodes("Dnn.DriversWebshop.PcScoreCalculator"))
        //{
        //    Dnn.DriversWebshop.PcScoreCalculatorInfo objDnn.DriversWebshop.PcScoreCalculator = new Dnn.DriversWebshop.PcScoreCalculatorInfo();
        //    objDnn.DriversWebshop.PcScoreCalculator.ModuleId = ModuleID;
        //    objDnn.DriversWebshop.PcScoreCalculator.Content = xmlDnn.DriversWebshop.PcScoreCalculator.SelectSingleNode("content").InnerText;
        //    objDnn.DriversWebshop.PcScoreCalculator.CreatedByUser = UserID;
        //    AddDnn.DriversWebshop.PcScoreCalculator(objDnn.DriversWebshop.PcScoreCalculator);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.DriversWebshop.PcScoreCalculatorInfo> colDnn.DriversWebshop.PcScoreCalculators = GetDnn.DriversWebshop.PcScoreCalculators(ModInfo.ModuleID);

        //foreach (Dnn.DriversWebshop.PcScoreCalculatorInfo objDnn.DriversWebshop.PcScoreCalculator in colDnn.DriversWebshop.PcScoreCalculators)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.DriversWebshop.PcScoreCalculator.Content, objDnn.DriversWebshop.PcScoreCalculator.CreatedByUser, objDnn.DriversWebshop.PcScoreCalculator.CreatedDate, ModInfo.ModuleID, objDnn.DriversWebshop.PcScoreCalculator.ItemId.ToString(), objDnn.DriversWebshop.PcScoreCalculator.Content, "ItemId=" + objDnn.DriversWebshop.PcScoreCalculator.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
