namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Drawing;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;
    using AppliedSystems.Tam.Ui.Tests.UIElements;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class UIMap
    {
        private MTAEffectiveDateParams mMtaEffectiveDateParams;

        private MotoCreateSiteRenewalParams mMotoCreateSiteRenewalParams;

        private OpenBrowser2Params mOpenBrowser2Params;

        private HomeFinishQuoteParams mHomeFinishQuoteParams;

        private MotoAWAPParams mMotoAwapParams;

        private MotoAmendRiskRenewParams mMotoAmendRiskRenewParams;

        private MotoAmendRiskNew_1Params mMotoAmendRiskNew1Params;

        private RenewalModuleInvite_1Params mRenewalModuleInvite1Params;

        private HomePrintQuote_1Params mHomePrintQuote1Params;

        private HomeExitWithPolicyParams mHomeExitWithPolicyParams;

        private HomeAcceptPolicyParams mHomeAcceptPolicyParams;

        private AcceptEnabledExpectedValues mAcceptEnabledExpectedValues;

        private AddPolicyParams mAddPolicyParams;

        private AddressLookupHomeExpectedValues mAddressLookupHomeExpectedValues;

        private HomeCheckPremiumExpectedValues mHomeCheckPremiumExpectedValues;

        private HomeCheckPrintExpectedValues mHomeCheckPrintExpectedValues;

        private HomeCheckStatusExpectedValues mHomeCheckStatusExpectedValues;

        private HomeCheckZeroPremiumExpectedValues mHomeCheckZeroPremiumExpectedValues;

        private HomeCopyCheckDataExpectedValues mHomeCopyCheckDataExpectedValues;

        private HomeCopyRiskParams mHomeCopyRiskParams;

        private HomeCheckPolicyPremiumExpectedValues mHomeCheckPolicyPremiumExpectedValues;

        private HomeExitWithoutPolicyParams mHomeExitWithoutPolicyParams;

        private HomeMTAChangeParams mHomeMtaChangeParams;

        private HomeMTACheckCancelledExpectedValues mHomeMTACheckCancelledExpectedValues;

        private HomeMTACheckChangedExpectedValues mHomeMTACheckChangedExpectedValues;

        private HomeMTACheckMessageExpectedValues mHomeMTACheckMessageExpectedValues;

        private HomeMTACopyCheckExpectedValues mHomeMTACopyCheckExpectedValues;

        private AmendDateBeforeMessageExpectedValues mAmendDateBeforeMessageExpectedValues;

        private HomeAddressLookupExpectedValues mHomeAddressLookupExpectedValues;

        private HomeAcceptQuote_1Params mHomeAcceptQuote_1Params;

        private ExitEnabledExpectedValues mExitEnabledExpectedValues;

        private FinishQuote1Params mFinishQuote1Params;

        private Exit1Params mExit1Params;

        private CoverDateBackCheckExpectedValues mCoverDateBackCheckExpectedValues;

        private CheckQuoteMessageExpectedValues mCheckQuoteMessageExpectedValues;

        private CheckDemandsDocExpectedValues mCheckDemandsDocExpectedValues;

        private CheckBillingScreenExpectedValues mCheckBillingScreenExpectedValues;

        private CheckAutoPrintExpectedValues mCheckAutoPrintExpectedValues;

        private ChangePremiumParams mChangePremiumParams;

        private ChangeDatePolicyParams mChangeDatePolicyParams;

        private AssertSelectPolicyFormExpectedValues mAssertSelectPolicyFormExpectedValues;

        private AssertMethod5ExpectedValues mAssertMethod5ExpectedValues;

        private AssertMethod4ExpectedValues mAssertMethod4ExpectedValues;

        private AssertMethod3ExpectedValues mAssertMethod3ExpectedValues;

        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;

        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;

        private App_startedExpectedValues mApp_startedExpectedValues;

        private AmendSelectQuoteParams mAmendSelectQuoteParams;

        private HomeProposerParams mHomeProposerParams;

        private HomeMTASelectQuoteParams mHomeMTASelectQuoteParams;

        private HomeMTAEnterDateParams mHomeMTAEnterDateParams;

        private HomeCreatePolicyParams mHomeCreatePolicyParams;

        private HomeCheckNewPremiumExpectedValues mHomeCheckNewPremiumExpectedValues;

        private HomeCheckDemandsExpectedValues mHomeCheckDemandsExpectedValues;

        private HomeChangePremiumParams mHomeChangePremiumParams;

        private HomeCancelPolicyAcceptParams mHomeCancelPolicyAcceptParams;

        private HomeCancelPolicyParams mHomeCancelPolicyParams;

        private HomeAmendSelecPolicyParams mHomeAmendSelecPolicyParams;

        private HomeAmendRiskParams mHomeAmendRiskParams;

        private HomeAmendRenewFinish_1Params mHomeAmendRenewFinish_1Params;

        private HomeAmendRenewParams mHomeAmendRenewParams;

        private MotoCopyFinishParams mMotoCopyFinishParams;

        private MotoCopyCheckProposerExpectedValues mMotoCopyCheckProposerExpectedValues;

        private MotoCopyCheckCarExpectedValues mMotoCopyCheckCarExpectedValues;

        private MotoCheckPolicyStatusExpectedValues mMotoCheckPolicyStatusExpectedValues;

        private MotoCheckChangedPremiumExpectedValues mMotoCheckChangedPremiumExpectedValues;

        private MotoCheckAWAPpremiumExpectedValues mMotoCheckAWAPpremiumExpectedValues;

        private MotoCancelPolicyParams mMotoCancelPolicyParams;

        private MotoAWAPCheckTAXExpectedValues mMotoAWAPCheckTAXExpectedValues;

        private MotoAWAPCheckNEWExpectedValues mMotoAWAPCheckNEWExpectedValues;

        private MotoAmendRiskParams mMotoAmendRiskParams;

        private HouseRegressAppParams mHouseRegressAppParams;

        private HouseProposerParams mHouseProposerParams;

        private HomeStartDateParams mHomeStartDateParams;

        private HomeSiteRenewalParams mHomeSiteRenewalParams;

        private HomeSelectPolicy1Params mHomeSelectPolicy1Params;

        private HomeSelectPolicyParams mHomeSelectPolicyParams;

        private HomeRenewalCancelledCheckExpectedValues mHomeRenewalCancelledCheckExpectedValues;

        private HomeRenewalBeforeFinishParams mHomeRenewalBeforeFinishParams;

        private HomeRenewalBeforeAcceptParams mHomeRenewalBeforeAcceptParams;

        private HomeRebrokeSelectPolicyParams mHomeRebrokeSelectPolicyParams;

        private testPrintParams mtestPrintParams;

        private SelectPolicyQuoteParams mSelectPolicyQuoteParams;

        private SelectNextTransactionParams mSelectNextTransactionParams;

        private SelectMotoPolicyParams mSelectMotoPolicyParams;

        private SelectHomeTypeParams mSelectHomeTypeParams;

        private SaveWithoutPremiumParams mSaveWithoutPremiumParams;

        private RenewalModuleRenew_1Params mRenewalModuleRenew_1Params;

        private RenewalModuleFilterMotoParams mRenewalModuleFilterMotoParams;

        private RenewalModuleEDIParams mRenewalModuleEDIParams;

        private RenewalModuleDisplayParams mRenewalModuleDisplayParams;

        private RenewalLoaderRunParams mRenewalLoaderRunParams;

        private RenewalCheckStatusExpectedValues mRenewalCheckStatusExpectedValues;

        private RenewalCheckInvitedExpectedValues mRenewalCheckInvitedExpectedValues;

        private RenewalAfterMTA1Params mRenewalAfterMTA1Params;

        private RegressAppDateParams mRegressAppDateParams;

        private RegistryHighwayParams mRegistryHighwayParams;

        private RecordedMethod5Params mRecordedMethod5Params;

        private RecordedMethod3Params mRecordedMethod3Params;

        private RecordedMethod2Params mRecordedMethod2Params;

        private RebrokeAlternativeRenew_1Params mRebrokeAlternativeRenew_1Params;

        private RebrokeAlternativeRenewParams mRebrokeAlternativeRenewParams;

        private RebrokeAlternativeFinish_1Params mRebrokeAlternativeFinish_1Params;

        private RebrokeAlternativeFinishParams mRebrokeAlternativeFinishParams;

        private QuoteResultsParams mQuoteResultsParams;

        private PostcodeLookupExpectedValues mPostcodeLookupExpectedValues;

        private OpenSiteForRenewalParams mOpenSiteForRenewalParams;

        private MTAMessageBeforeCurrentExpectedValues mMTAMessageBeforeCurrentExpectedValues;

        private MTADateParams mMTADateParams;

        private MotoSelectHighwayPolicyParams mMotoSelectHighwayPolicyParams;

        private MotoSearchCarParams mMotoSearchCarParams;

        private MotoRenewalCheckRecordExpectedValues mMotoRenewalCheckRecordExpectedValues;

        private MotoRegressAppParams mMotoRegressAppParams;

        private MotoRebrokeSelectSchemeParams mMotoRebrokeSelectSchemeParams;

        private MotoPostcodeLookupParams mMotoPostcodeLookupParams;

        private MotoPolicyPersonParams mMotoPolicyPersonParams;

        private MotoMTANoSaveParams mMotoMTANoSaveParams;

        private MotoMTAMessageCancelledExpectedValues mMotoMTAMessageCancelledExpectedValues;

        private MotoMTAMessageAfterDateExpectedValues mMotoMTAMessageAfterDateExpectedValues;

        private MotoMTAConfirmPolicyParams mMotoMTAConfirmPolicyParams;

        private MotoMTACheckNewValueExpectedValues mMotoMTACheckNewValueExpectedValues;

        private MotoMTACheckCarExpectedValues mMotoMTACheckCarExpectedValues;

        private MotoMTABeforeFinishParams mMotoMTABeforeFinishParams;

        private MotoMTABeforeAcceptParams mMotoMTABeforeAcceptParams;

        private MotoMTABefore2Params mMotoMTABefore2Params;

        private MotoMTABeforeParams mMotoMTABeforeParams;

        private MotoMTAAcceptParams mMotoMTAAcceptParams;

        private MotoInceptionDateParams mMotoInceptionDateParams;

        private MotoFinishMTAParams mMotoFinishMTAParams;

        public virtual MTAEffectiveDateParams MTAEffectiveDateParams
        {
            get
            {
                if ((this.mMtaEffectiveDateParams == null))
                {
                    this.mMtaEffectiveDateParams = new MTAEffectiveDateParams();
                }
                return this.mMtaEffectiveDateParams;
            }
        }

        public virtual MotoCreateSiteRenewalParams MotoCreateSiteRenewalParams
        {
            get
            {
                if ((this.mMotoCreateSiteRenewalParams == null))
                {
                    this.mMotoCreateSiteRenewalParams = new MotoCreateSiteRenewalParams();
                }
                return this.mMotoCreateSiteRenewalParams;
            }
        }

        public virtual OpenBrowser2Params OpenBrowser2Params
        {
            get
            {
                if ((this.mOpenBrowser2Params == null))
                {
                    this.mOpenBrowser2Params = new OpenBrowser2Params();
                }
                return this.mOpenBrowser2Params;
            }
        }

        public virtual HomeFinishQuoteParams HomeFinishQuoteParams
        {
            get
            {
                if ((this.mHomeFinishQuoteParams == null))
                {
                    this.mHomeFinishQuoteParams = new HomeFinishQuoteParams();
                }
                return this.mHomeFinishQuoteParams;
            }
        }

        public virtual MotoAWAPParams MotoAWAPParams
        {
            get
            {
                if ((this.mMotoAwapParams == null))
                {
                    this.mMotoAwapParams = new MotoAWAPParams();
                }
                return this.mMotoAwapParams;
            }
        }

        public virtual MotoAmendRiskRenewParams MotoAmendRiskRenewParams
        {
            get
            {
                if ((this.mMotoAmendRiskRenewParams == null))
                {
                    this.mMotoAmendRiskRenewParams = new MotoAmendRiskRenewParams();
                }
                return this.mMotoAmendRiskRenewParams;
            }
        }

        public virtual MotoAmendRiskNew_1Params MotoAmendRiskNew_1Params
        {
            get
            {
                if ((this.mMotoAmendRiskNew1Params == null))
                {
                    this.mMotoAmendRiskNew1Params = new MotoAmendRiskNew_1Params();
                }
                return this.mMotoAmendRiskNew1Params;
            }
        }

        public virtual RenewalModuleInvite_1Params RenewalModuleInvite_1Params
        {
            get
            {
                if ((this.mRenewalModuleInvite1Params == null))
                {
                    this.mRenewalModuleInvite1Params = new RenewalModuleInvite_1Params();
                }
                return this.mRenewalModuleInvite1Params;
            }
        }

        public virtual HomePrintQuote_1Params HomePrintQuote_1Params
        {
            get
            {
                if ((this.mHomePrintQuote1Params == null))
                {
                    this.mHomePrintQuote1Params = new HomePrintQuote_1Params();
                }
                return this.mHomePrintQuote1Params;
            }
        }

        public virtual HomeExitWithPolicyParams HomeExitWithPolicyParams
        {
            get
            {
                if ((this.mHomeExitWithPolicyParams == null))
                {
                    this.mHomeExitWithPolicyParams = new HomeExitWithPolicyParams();
                }
                return this.mHomeExitWithPolicyParams;
            }
        }

        public virtual HomeAcceptPolicyParams HomeAcceptPolicyParams
        {
            get
            {
                if ((this.mHomeAcceptPolicyParams == null))
                {
                    this.mHomeAcceptPolicyParams = new HomeAcceptPolicyParams();
                }
                return this.mHomeAcceptPolicyParams;
            }
        }

        public virtual AcceptEnabledExpectedValues AcceptEnabledExpectedValues
        {
            get
            {
                if ((this.mAcceptEnabledExpectedValues == null))
                {
                    this.mAcceptEnabledExpectedValues = new AcceptEnabledExpectedValues();
                }
                return this.mAcceptEnabledExpectedValues;
            }
        }

        public virtual AddPolicyParams AddPolicyParams
        {
            get
            {
                if ((this.mAddPolicyParams == null))
                {
                    this.mAddPolicyParams = new AddPolicyParams();
                }
                return this.mAddPolicyParams;
            }
        }

        public virtual AddressLookupHomeExpectedValues AddressLookupHomeExpectedValues
        {
            get
            {
                if ((this.mAddressLookupHomeExpectedValues == null))
                {
                    this.mAddressLookupHomeExpectedValues = new AddressLookupHomeExpectedValues();
                }
                return this.mAddressLookupHomeExpectedValues;
            }
        }

        public virtual HomeCheckPremiumExpectedValues HomeCheckPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckPremiumExpectedValues == null))
                {
                    this.mHomeCheckPremiumExpectedValues = new HomeCheckPremiumExpectedValues();
                }
                return this.mHomeCheckPremiumExpectedValues;
            }
        }

        public virtual HomeCheckPrintExpectedValues HomeCheckPrintExpectedValues
        {
            get
            {
                if ((this.mHomeCheckPrintExpectedValues == null))
                {
                    this.mHomeCheckPrintExpectedValues = new HomeCheckPrintExpectedValues();
                }
                return this.mHomeCheckPrintExpectedValues;
            }
        }

        public virtual HomeCheckStatusExpectedValues HomeCheckStatusExpectedValues
        {
            get
            {
                if ((this.mHomeCheckStatusExpectedValues == null))
                {
                    this.mHomeCheckStatusExpectedValues = new HomeCheckStatusExpectedValues();
                }
                return this.mHomeCheckStatusExpectedValues;
            }
        }

        public virtual HomeCheckZeroPremiumExpectedValues HomeCheckZeroPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckZeroPremiumExpectedValues == null))
                {
                    this.mHomeCheckZeroPremiumExpectedValues = new HomeCheckZeroPremiumExpectedValues();
                }
                return this.mHomeCheckZeroPremiumExpectedValues;
            }
        }

        public virtual HomeCopyCheckDataExpectedValues HomeCopyCheckDataExpectedValues
        {
            get
            {
                if ((this.mHomeCopyCheckDataExpectedValues == null))
                {
                    this.mHomeCopyCheckDataExpectedValues = new HomeCopyCheckDataExpectedValues();
                }
                return this.mHomeCopyCheckDataExpectedValues;
            }
        }

        public virtual HomeCopyRiskParams HomeCopyRiskParams
        {
            get
            {
                if ((this.mHomeCopyRiskParams == null))
                {
                    this.mHomeCopyRiskParams = new HomeCopyRiskParams();
                }
                return this.mHomeCopyRiskParams;
            }
        }

        public virtual HomeCheckPolicyPremiumExpectedValues HomeCheckPolicyPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckPolicyPremiumExpectedValues == null))
                {
                    this.mHomeCheckPolicyPremiumExpectedValues = new HomeCheckPolicyPremiumExpectedValues();
                }
                return this.mHomeCheckPolicyPremiumExpectedValues;
            }
        }

        public virtual HomeExitWithoutPolicyParams HomeExitWithoutPolicyParams
        {
            get
            {
                if ((this.mHomeExitWithoutPolicyParams == null))
                {
                    this.mHomeExitWithoutPolicyParams = new HomeExitWithoutPolicyParams();
                }
                return this.mHomeExitWithoutPolicyParams;
            }
        }

        public virtual HomeMTAChangeParams HomeMTAChangeParams
        {
            get
            {
                if ((this.mHomeMtaChangeParams == null))
                {
                    this.mHomeMtaChangeParams = new HomeMTAChangeParams();
                }
                return this.mHomeMtaChangeParams;
            }
        }

        public virtual HomeMTACheckCancelledExpectedValues HomeMTACheckCancelledExpectedValues
        {
            get
            {
                if ((this.mHomeMTACheckCancelledExpectedValues == null))
                {
                    this.mHomeMTACheckCancelledExpectedValues = new HomeMTACheckCancelledExpectedValues();
                }
                return this.mHomeMTACheckCancelledExpectedValues;
            }
        }

        public virtual HomeMTACheckChangedExpectedValues HomeMTACheckChangedExpectedValues
        {
            get
            {
                if ((this.mHomeMTACheckChangedExpectedValues == null))
                {
                    this.mHomeMTACheckChangedExpectedValues = new HomeMTACheckChangedExpectedValues();
                }
                return this.mHomeMTACheckChangedExpectedValues;
            }
        }

        public virtual HomeMTACheckMessageExpectedValues HomeMTACheckMessageExpectedValues
        {
            get
            {
                if ((this.mHomeMTACheckMessageExpectedValues == null))
                {
                    this.mHomeMTACheckMessageExpectedValues = new HomeMTACheckMessageExpectedValues();
                }
                return this.mHomeMTACheckMessageExpectedValues;
            }
        }

        public virtual HomeMTACopyCheckExpectedValues HomeMTACopyCheckExpectedValues
        {
            get
            {
                if ((this.mHomeMTACopyCheckExpectedValues == null))
                {
                    this.mHomeMTACopyCheckExpectedValues = new HomeMTACopyCheckExpectedValues();
                }
                return this.mHomeMTACopyCheckExpectedValues;
            }
        }

        public virtual AmendDateBeforeMessageExpectedValues AmendDateBeforeMessageExpectedValues
        {
            get
            {
                if ((this.mAmendDateBeforeMessageExpectedValues == null))
                {
                    this.mAmendDateBeforeMessageExpectedValues = new AmendDateBeforeMessageExpectedValues();
                }
                return this.mAmendDateBeforeMessageExpectedValues;
            }
        }

        public virtual HomeAddressLookupExpectedValues HomeAddressLookupExpectedValues
        {
            get
            {
                if ((this.mHomeAddressLookupExpectedValues == null))
                {
                    this.mHomeAddressLookupExpectedValues = new HomeAddressLookupExpectedValues();
                }
                return this.mHomeAddressLookupExpectedValues;
            }
        }

        public virtual HomeAcceptQuote_1Params HomeAcceptQuote_1Params
        {
            get
            {
                if ((this.mHomeAcceptQuote_1Params == null))
                {
                    this.mHomeAcceptQuote_1Params = new HomeAcceptQuote_1Params();
                }
                return this.mHomeAcceptQuote_1Params;
            }
        }

        public virtual ExitEnabledExpectedValues ExitEnabledExpectedValues
        {
            get
            {
                if ((this.mExitEnabledExpectedValues == null))
                {
                    this.mExitEnabledExpectedValues = new ExitEnabledExpectedValues();
                }
                return this.mExitEnabledExpectedValues;
            }
        }

        public virtual FinishQuote1Params FinishQuote1Params
        {
            get
            {
                if ((this.mFinishQuote1Params == null))
                {
                    this.mFinishQuote1Params = new FinishQuote1Params();
                }
                return this.mFinishQuote1Params;
            }
        }

        public virtual Exit1Params Exit1Params
        {
            get
            {
                if ((this.mExit1Params == null))
                {
                    this.mExit1Params = new Exit1Params();
                }
                return this.mExit1Params;
            }
        }

        public virtual CoverDateBackCheckExpectedValues CoverDateBackCheckExpectedValues
        {
            get
            {
                if ((this.mCoverDateBackCheckExpectedValues == null))
                {
                    this.mCoverDateBackCheckExpectedValues = new CoverDateBackCheckExpectedValues();
                }
                return this.mCoverDateBackCheckExpectedValues;
            }
        }

        public virtual CheckQuoteMessageExpectedValues CheckQuoteMessageExpectedValues
        {
            get
            {
                if ((this.mCheckQuoteMessageExpectedValues == null))
                {
                    this.mCheckQuoteMessageExpectedValues = new CheckQuoteMessageExpectedValues();
                }
                return this.mCheckQuoteMessageExpectedValues;
            }
        }

        public virtual CheckDemandsDocExpectedValues CheckDemandsDocExpectedValues
        {
            get
            {
                if ((this.mCheckDemandsDocExpectedValues == null))
                {
                    this.mCheckDemandsDocExpectedValues = new CheckDemandsDocExpectedValues();
                }
                return this.mCheckDemandsDocExpectedValues;
            }
        }

        public virtual CheckBillingScreenExpectedValues CheckBillingScreenExpectedValues
        {
            get
            {
                if ((this.mCheckBillingScreenExpectedValues == null))
                {
                    this.mCheckBillingScreenExpectedValues = new CheckBillingScreenExpectedValues();
                }
                return this.mCheckBillingScreenExpectedValues;
            }
        }

        public virtual CheckAutoPrintExpectedValues CheckAutoPrintExpectedValues
        {
            get
            {
                if ((this.mCheckAutoPrintExpectedValues == null))
                {
                    this.mCheckAutoPrintExpectedValues = new CheckAutoPrintExpectedValues();
                }
                return this.mCheckAutoPrintExpectedValues;
            }
        }

        public virtual ChangePremiumParams ChangePremiumParams
        {
            get
            {
                if ((this.mChangePremiumParams == null))
                {
                    this.mChangePremiumParams = new ChangePremiumParams();
                }
                return this.mChangePremiumParams;
            }
        }

        public virtual ChangeDatePolicyParams ChangeDatePolicyParams
        {
            get
            {
                if ((this.mChangeDatePolicyParams == null))
                {
                    this.mChangeDatePolicyParams = new ChangeDatePolicyParams();
                }
                return this.mChangeDatePolicyParams;
            }
        }

        public virtual AssertSelectPolicyFormExpectedValues AssertSelectPolicyFormExpectedValues
        {
            get
            {
                if ((this.mAssertSelectPolicyFormExpectedValues == null))
                {
                    this.mAssertSelectPolicyFormExpectedValues = new AssertSelectPolicyFormExpectedValues();
                }
                return this.mAssertSelectPolicyFormExpectedValues;
            }
        }

        public virtual AssertMethod5ExpectedValues AssertMethod5ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod5ExpectedValues == null))
                {
                    this.mAssertMethod5ExpectedValues = new AssertMethod5ExpectedValues();
                }
                return this.mAssertMethod5ExpectedValues;
            }
        }

        public virtual AssertMethod4ExpectedValues AssertMethod4ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod4ExpectedValues == null))
                {
                    this.mAssertMethod4ExpectedValues = new AssertMethod4ExpectedValues();
                }
                return this.mAssertMethod4ExpectedValues;
            }
        }

        public virtual AssertMethod3ExpectedValues AssertMethod3ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod3ExpectedValues == null))
                {
                    this.mAssertMethod3ExpectedValues = new AssertMethod3ExpectedValues();
                }
                return this.mAssertMethod3ExpectedValues;
            }
        }

        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }

        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }

        public virtual App_startedExpectedValues App_startedExpectedValues
        {
            get
            {
                if ((this.mApp_startedExpectedValues == null))
                {
                    this.mApp_startedExpectedValues = new App_startedExpectedValues();
                }
                return this.mApp_startedExpectedValues;
            }
        }

        public virtual AmendSelectQuoteParams AmendSelectQuoteParams
        {
            get
            {
                if ((this.mAmendSelectQuoteParams == null))
                {
                    this.mAmendSelectQuoteParams = new AmendSelectQuoteParams();
                }
                return this.mAmendSelectQuoteParams;
            }
        }

        public virtual HomeProposerParams HomeProposerParams
        {
            get
            {
                if ((this.mHomeProposerParams == null))
                {
                    this.mHomeProposerParams = new HomeProposerParams();
                }
                return this.mHomeProposerParams;
            }
        }

        public virtual HomeMTASelectQuoteParams HomeMTASelectQuoteParams
        {
            get
            {
                if ((this.mHomeMTASelectQuoteParams == null))
                {
                    this.mHomeMTASelectQuoteParams = new HomeMTASelectQuoteParams();
                }
                return this.mHomeMTASelectQuoteParams;
            }
        }

        public virtual HomeMTAEnterDateParams HomeMTAEnterDateParams
        {
            get
            {
                if ((this.mHomeMTAEnterDateParams == null))
                {
                    this.mHomeMTAEnterDateParams = new HomeMTAEnterDateParams();
                }
                return this.mHomeMTAEnterDateParams;
            }
        }

        public virtual HomeCreatePolicyParams HomeCreatePolicyParams
        {
            get
            {
                if ((this.mHomeCreatePolicyParams == null))
                {
                    this.mHomeCreatePolicyParams = new HomeCreatePolicyParams();
                }
                return this.mHomeCreatePolicyParams;
            }
        }

        public virtual HomeCheckNewPremiumExpectedValues HomeCheckNewPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckNewPremiumExpectedValues == null))
                {
                    this.mHomeCheckNewPremiumExpectedValues = new HomeCheckNewPremiumExpectedValues();
                }
                return this.mHomeCheckNewPremiumExpectedValues;
            }
        }

        public virtual HomeCheckDemandsExpectedValues HomeCheckDemandsExpectedValues
        {
            get
            {
                if ((this.mHomeCheckDemandsExpectedValues == null))
                {
                    this.mHomeCheckDemandsExpectedValues = new HomeCheckDemandsExpectedValues();
                }
                return this.mHomeCheckDemandsExpectedValues;
            }
        }

        public virtual HomeChangePremiumParams HomeChangePremiumParams
        {
            get
            {
                if ((this.mHomeChangePremiumParams == null))
                {
                    this.mHomeChangePremiumParams = new HomeChangePremiumParams();
                }
                return this.mHomeChangePremiumParams;
            }
        }

        public virtual HomeCancelPolicyAcceptParams HomeCancelPolicyAcceptParams
        {
            get
            {
                if ((this.mHomeCancelPolicyAcceptParams == null))
                {
                    this.mHomeCancelPolicyAcceptParams = new HomeCancelPolicyAcceptParams();
                }
                return this.mHomeCancelPolicyAcceptParams;
            }
        }

        public virtual HomeCancelPolicyParams HomeCancelPolicyParams
        {
            get
            {
                if ((this.mHomeCancelPolicyParams == null))
                {
                    this.mHomeCancelPolicyParams = new HomeCancelPolicyParams();
                }
                return this.mHomeCancelPolicyParams;
            }
        }

        public virtual HomeAmendSelecPolicyParams HomeAmendSelecPolicyParams
        {
            get
            {
                if ((this.mHomeAmendSelecPolicyParams == null))
                {
                    this.mHomeAmendSelecPolicyParams = new HomeAmendSelecPolicyParams();
                }
                return this.mHomeAmendSelecPolicyParams;
            }
        }

        public virtual HomeAmendRiskParams HomeAmendRiskParams
        {
            get
            {
                if ((this.mHomeAmendRiskParams == null))
                {
                    this.mHomeAmendRiskParams = new HomeAmendRiskParams();
                }
                return this.mHomeAmendRiskParams;
            }
        }

        public virtual HomeAmendRenewFinish_1Params HomeAmendRenewFinish_1Params
        {
            get
            {
                if ((this.mHomeAmendRenewFinish_1Params == null))
                {
                    this.mHomeAmendRenewFinish_1Params = new HomeAmendRenewFinish_1Params();
                }
                return this.mHomeAmendRenewFinish_1Params;
            }
        }

        public virtual HomeAmendRenewParams HomeAmendRenewParams
        {
            get
            {
                if ((this.mHomeAmendRenewParams == null))
                {
                    this.mHomeAmendRenewParams = new HomeAmendRenewParams();
                }
                return this.mHomeAmendRenewParams;
            }
        }

        public virtual MotoCopyFinishParams MotoCopyFinishParams
        {
            get
            {
                if ((this.mMotoCopyFinishParams == null))
                {
                    this.mMotoCopyFinishParams = new MotoCopyFinishParams();
                }
                return this.mMotoCopyFinishParams;
            }
        }

        public virtual MotoCopyCheckProposerExpectedValues MotoCopyCheckProposerExpectedValues
        {
            get
            {
                if ((this.mMotoCopyCheckProposerExpectedValues == null))
                {
                    this.mMotoCopyCheckProposerExpectedValues = new MotoCopyCheckProposerExpectedValues();
                }
                return this.mMotoCopyCheckProposerExpectedValues;
            }
        }

        public virtual MotoCopyCheckCarExpectedValues MotoCopyCheckCarExpectedValues
        {
            get
            {
                if ((this.mMotoCopyCheckCarExpectedValues == null))
                {
                    this.mMotoCopyCheckCarExpectedValues = new MotoCopyCheckCarExpectedValues();
                }
                return this.mMotoCopyCheckCarExpectedValues;
            }
        }

        public virtual MotoCheckPolicyStatusExpectedValues MotoCheckPolicyStatusExpectedValues
        {
            get
            {
                if ((this.mMotoCheckPolicyStatusExpectedValues == null))
                {
                    this.mMotoCheckPolicyStatusExpectedValues = new MotoCheckPolicyStatusExpectedValues();
                }
                return this.mMotoCheckPolicyStatusExpectedValues;
            }
        }

        public virtual MotoCheckChangedPremiumExpectedValues MotoCheckChangedPremiumExpectedValues
        {
            get
            {
                if ((this.mMotoCheckChangedPremiumExpectedValues == null))
                {
                    this.mMotoCheckChangedPremiumExpectedValues = new MotoCheckChangedPremiumExpectedValues();
                }
                return this.mMotoCheckChangedPremiumExpectedValues;
            }
        }

        public virtual MotoCheckAWAPpremiumExpectedValues MotoCheckAWAPpremiumExpectedValues
        {
            get
            {
                if ((this.mMotoCheckAWAPpremiumExpectedValues == null))
                {
                    this.mMotoCheckAWAPpremiumExpectedValues = new MotoCheckAWAPpremiumExpectedValues();
                }
                return this.mMotoCheckAWAPpremiumExpectedValues;
            }
        }

        public virtual MotoCancelPolicyParams MotoCancelPolicyParams
        {
            get
            {
                if ((this.mMotoCancelPolicyParams == null))
                {
                    this.mMotoCancelPolicyParams = new MotoCancelPolicyParams();
                }
                return this.mMotoCancelPolicyParams;
            }
        }

        public virtual MotoAWAPCheckTAXExpectedValues MotoAWAPCheckTAXExpectedValues
        {
            get
            {
                if ((this.mMotoAWAPCheckTAXExpectedValues == null))
                {
                    this.mMotoAWAPCheckTAXExpectedValues = new MotoAWAPCheckTAXExpectedValues();
                }
                return this.mMotoAWAPCheckTAXExpectedValues;
            }
        }

        public virtual MotoAWAPCheckNEWExpectedValues MotoAWAPCheckNEWExpectedValues
        {
            get
            {
                if ((this.mMotoAWAPCheckNEWExpectedValues == null))
                {
                    this.mMotoAWAPCheckNEWExpectedValues = new MotoAWAPCheckNEWExpectedValues();
                }
                return this.mMotoAWAPCheckNEWExpectedValues;
            }
        }

        public virtual MotoAmendRiskParams MotoAmendRiskParams
        {
            get
            {
                if ((this.mMotoAmendRiskParams == null))
                {
                    this.mMotoAmendRiskParams = new MotoAmendRiskParams();
                }
                return this.mMotoAmendRiskParams;
            }
        }

        public virtual HouseRegressAppParams HouseRegressAppParams
        {
            get
            {
                if ((this.mHouseRegressAppParams == null))
                {
                    this.mHouseRegressAppParams = new HouseRegressAppParams();
                }
                return this.mHouseRegressAppParams;
            }
        }

        public virtual HouseProposerParams HouseProposerParams
        {
            get
            {
                if ((this.mHouseProposerParams == null))
                {
                    this.mHouseProposerParams = new HouseProposerParams();
                }
                return this.mHouseProposerParams;
            }
        }

        public virtual HomeStartDateParams HomeStartDateParams
        {
            get
            {
                if ((this.mHomeStartDateParams == null))
                {
                    this.mHomeStartDateParams = new HomeStartDateParams();
                }
                return this.mHomeStartDateParams;
            }
        }

        public virtual HomeSiteRenewalParams HomeSiteRenewalParams
        {
            get
            {
                if ((this.mHomeSiteRenewalParams == null))
                {
                    this.mHomeSiteRenewalParams = new HomeSiteRenewalParams();
                }
                return this.mHomeSiteRenewalParams;
            }
        }

        public virtual HomeSelectPolicy1Params HomeSelectPolicy1Params
        {
            get
            {
                if ((this.mHomeSelectPolicy1Params == null))
                {
                    this.mHomeSelectPolicy1Params = new HomeSelectPolicy1Params();
                }
                return this.mHomeSelectPolicy1Params;
            }
        }

        public virtual HomeSelectPolicyParams HomeSelectPolicyParams
        {
            get
            {
                if ((this.mHomeSelectPolicyParams == null))
                {
                    this.mHomeSelectPolicyParams = new HomeSelectPolicyParams();
                }
                return this.mHomeSelectPolicyParams;
            }
        }

        public virtual HomeRenewalCancelledCheckExpectedValues HomeRenewalCancelledCheckExpectedValues
        {
            get
            {
                if ((this.mHomeRenewalCancelledCheckExpectedValues == null))
                {
                    this.mHomeRenewalCancelledCheckExpectedValues = new HomeRenewalCancelledCheckExpectedValues();
                }
                return this.mHomeRenewalCancelledCheckExpectedValues;
            }
        }

        public virtual HomeRenewalBeforeFinishParams HomeRenewalBeforeFinishParams
        {
            get
            {
                if ((this.mHomeRenewalBeforeFinishParams == null))
                {
                    this.mHomeRenewalBeforeFinishParams = new HomeRenewalBeforeFinishParams();
                }
                return this.mHomeRenewalBeforeFinishParams;
            }
        }

        public virtual HomeRenewalBeforeAcceptParams HomeRenewalBeforeAcceptParams
        {
            get
            {
                if ((this.mHomeRenewalBeforeAcceptParams == null))
                {
                    this.mHomeRenewalBeforeAcceptParams = new HomeRenewalBeforeAcceptParams();
                }
                return this.mHomeRenewalBeforeAcceptParams;
            }
        }

        public virtual HomeRebrokeSelectPolicyParams HomeRebrokeSelectPolicyParams
        {
            get
            {
                if ((this.mHomeRebrokeSelectPolicyParams == null))
                {
                    this.mHomeRebrokeSelectPolicyParams = new HomeRebrokeSelectPolicyParams();
                }
                return this.mHomeRebrokeSelectPolicyParams;
            }
        }

        public virtual testPrintParams testPrintParams
        {
            get
            {
                if ((this.mtestPrintParams == null))
                {
                    this.mtestPrintParams = new testPrintParams();
                }
                return this.mtestPrintParams;
            }
        }

        public virtual SelectPolicyQuoteParams SelectPolicyQuoteParams
        {
            get
            {
                if ((this.mSelectPolicyQuoteParams == null))
                {
                    this.mSelectPolicyQuoteParams = new SelectPolicyQuoteParams();
                }
                return this.mSelectPolicyQuoteParams;
            }
        }

        public virtual SelectNextTransactionParams SelectNextTransactionParams
        {
            get
            {
                if ((this.mSelectNextTransactionParams == null))
                {
                    this.mSelectNextTransactionParams = new SelectNextTransactionParams();
                }
                return this.mSelectNextTransactionParams;
            }
        }

        public virtual SelectMotoPolicyParams SelectMotoPolicyParams
        {
            get
            {
                if ((this.mSelectMotoPolicyParams == null))
                {
                    this.mSelectMotoPolicyParams = new SelectMotoPolicyParams();
                }
                return this.mSelectMotoPolicyParams;
            }
        }

        public virtual SelectHomeTypeParams SelectHomeTypeParams
        {
            get
            {
                if ((this.mSelectHomeTypeParams == null))
                {
                    this.mSelectHomeTypeParams = new SelectHomeTypeParams();
                }
                return this.mSelectHomeTypeParams;
            }
        }

        public virtual SaveWithoutPremiumParams SaveWithoutPremiumParams
        {
            get
            {
                if ((this.mSaveWithoutPremiumParams == null))
                {
                    this.mSaveWithoutPremiumParams = new SaveWithoutPremiumParams();
                }
                return this.mSaveWithoutPremiumParams;
            }
        }

        public virtual RenewalModuleRenew_1Params RenewalModuleRenew_1Params
        {
            get
            {
                if ((this.mRenewalModuleRenew_1Params == null))
                {
                    this.mRenewalModuleRenew_1Params = new RenewalModuleRenew_1Params();
                }
                return this.mRenewalModuleRenew_1Params;
            }
        }

        public virtual RenewalModuleFilterMotoParams RenewalModuleFilterMotoParams
        {
            get
            {
                if ((this.mRenewalModuleFilterMotoParams == null))
                {
                    this.mRenewalModuleFilterMotoParams = new RenewalModuleFilterMotoParams();
                }
                return this.mRenewalModuleFilterMotoParams;
            }
        }

        public virtual RenewalModuleEDIParams RenewalModuleEDIParams
        {
            get
            {
                if ((this.mRenewalModuleEDIParams == null))
                {
                    this.mRenewalModuleEDIParams = new RenewalModuleEDIParams();
                }
                return this.mRenewalModuleEDIParams;
            }
        }

        public virtual RenewalModuleDisplayParams RenewalModuleDisplayParams
        {
            get
            {
                if ((this.mRenewalModuleDisplayParams == null))
                {
                    this.mRenewalModuleDisplayParams = new RenewalModuleDisplayParams();
                }
                return this.mRenewalModuleDisplayParams;
            }
        }

        public virtual RenewalLoaderRunParams RenewalLoaderRunParams
        {
            get
            {
                if ((this.mRenewalLoaderRunParams == null))
                {
                    this.mRenewalLoaderRunParams = new RenewalLoaderRunParams();
                }
                return this.mRenewalLoaderRunParams;
            }
        }

        public virtual RenewalCheckStatusExpectedValues RenewalCheckStatusExpectedValues
        {
            get
            {
                if ((this.mRenewalCheckStatusExpectedValues == null))
                {
                    this.mRenewalCheckStatusExpectedValues = new RenewalCheckStatusExpectedValues();
                }
                return this.mRenewalCheckStatusExpectedValues;
            }
        }

        public virtual RenewalCheckInvitedExpectedValues RenewalCheckInvitedExpectedValues
        {
            get
            {
                if ((this.mRenewalCheckInvitedExpectedValues == null))
                {
                    this.mRenewalCheckInvitedExpectedValues = new RenewalCheckInvitedExpectedValues();
                }
                return this.mRenewalCheckInvitedExpectedValues;
            }
        }

        public virtual RenewalAfterMTA1Params RenewalAfterMTA1Params
        {
            get
            {
                if ((this.mRenewalAfterMTA1Params == null))
                {
                    this.mRenewalAfterMTA1Params = new RenewalAfterMTA1Params();
                }
                return this.mRenewalAfterMTA1Params;
            }
        }

        public virtual RegressAppDateParams RegressAppDateParams
        {
            get
            {
                if ((this.mRegressAppDateParams == null))
                {
                    this.mRegressAppDateParams = new RegressAppDateParams();
                }
                return this.mRegressAppDateParams;
            }
        }

        public virtual RegistryHighwayParams RegistryHighwayParams
        {
            get
            {
                if ((this.mRegistryHighwayParams == null))
                {
                    this.mRegistryHighwayParams = new RegistryHighwayParams();
                }
                return this.mRegistryHighwayParams;
            }
        }

        public virtual RecordedMethod5Params RecordedMethod5Params
        {
            get
            {
                if ((this.mRecordedMethod5Params == null))
                {
                    this.mRecordedMethod5Params = new RecordedMethod5Params();
                }
                return this.mRecordedMethod5Params;
            }
        }

        public virtual RecordedMethod3Params RecordedMethod3Params
        {
            get
            {
                if ((this.mRecordedMethod3Params == null))
                {
                    this.mRecordedMethod3Params = new RecordedMethod3Params();
                }
                return this.mRecordedMethod3Params;
            }
        }

        public virtual RecordedMethod2Params RecordedMethod2Params
        {
            get
            {
                if ((this.mRecordedMethod2Params == null))
                {
                    this.mRecordedMethod2Params = new RecordedMethod2Params();
                }
                return this.mRecordedMethod2Params;
            }
        }

        public virtual RebrokeAlternativeRenew_1Params RebrokeAlternativeRenew_1Params
        {
            get
            {
                if ((this.mRebrokeAlternativeRenew_1Params == null))
                {
                    this.mRebrokeAlternativeRenew_1Params = new RebrokeAlternativeRenew_1Params();
                }
                return this.mRebrokeAlternativeRenew_1Params;
            }
        }

        public virtual RebrokeAlternativeRenewParams RebrokeAlternativeRenewParams
        {
            get
            {
                if ((this.mRebrokeAlternativeRenewParams == null))
                {
                    this.mRebrokeAlternativeRenewParams = new RebrokeAlternativeRenewParams();
                }
                return this.mRebrokeAlternativeRenewParams;
            }
        }

        public virtual RebrokeAlternativeFinish_1Params RebrokeAlternativeFinish_1Params
        {
            get
            {
                if ((this.mRebrokeAlternativeFinish_1Params == null))
                {
                    this.mRebrokeAlternativeFinish_1Params = new RebrokeAlternativeFinish_1Params();
                }
                return this.mRebrokeAlternativeFinish_1Params;
            }
        }

        public virtual RebrokeAlternativeFinishParams RebrokeAlternativeFinishParams
        {
            get
            {
                if ((this.mRebrokeAlternativeFinishParams == null))
                {
                    this.mRebrokeAlternativeFinishParams = new RebrokeAlternativeFinishParams();
                }
                return this.mRebrokeAlternativeFinishParams;
            }
        }

        public virtual QuoteResultsParams QuoteResultsParams
        {
            get
            {
                if ((this.mQuoteResultsParams == null))
                {
                    this.mQuoteResultsParams = new QuoteResultsParams();
                }
                return this.mQuoteResultsParams;
            }
        }

        public virtual PostcodeLookupExpectedValues PostcodeLookupExpectedValues
        {
            get
            {
                if ((this.mPostcodeLookupExpectedValues == null))
                {
                    this.mPostcodeLookupExpectedValues = new PostcodeLookupExpectedValues();
                }
                return this.mPostcodeLookupExpectedValues;
            }
        }

        public virtual OpenSiteForRenewalParams OpenSiteForRenewalParams
        {
            get
            {
                if ((this.mOpenSiteForRenewalParams == null))
                {
                    this.mOpenSiteForRenewalParams = new OpenSiteForRenewalParams();
                }
                return this.mOpenSiteForRenewalParams;
            }
        }

        public virtual MTAMessageBeforeCurrentExpectedValues MTAMessageBeforeCurrentExpectedValues
        {
            get
            {
                if ((this.mMTAMessageBeforeCurrentExpectedValues == null))
                {
                    this.mMTAMessageBeforeCurrentExpectedValues = new MTAMessageBeforeCurrentExpectedValues();
                }
                return this.mMTAMessageBeforeCurrentExpectedValues;
            }
        }

        public virtual MTADateParams MTADateParams
        {
            get
            {
                if ((this.mMTADateParams == null))
                {
                    this.mMTADateParams = new MTADateParams();
                }
                return this.mMTADateParams;
            }
        }

        public virtual MotoSelectHighwayPolicyParams MotoSelectHighwayPolicyParams
        {
            get
            {
                if ((this.mMotoSelectHighwayPolicyParams == null))
                {
                    this.mMotoSelectHighwayPolicyParams = new MotoSelectHighwayPolicyParams();
                }
                return this.mMotoSelectHighwayPolicyParams;
            }
        }

        public virtual MotoSearchCarParams MotoSearchCarParams
        {
            get
            {
                if ((this.mMotoSearchCarParams == null))
                {
                    this.mMotoSearchCarParams = new MotoSearchCarParams();
                }
                return this.mMotoSearchCarParams;
            }
        }

        public virtual MotoRenewalCheckRecordExpectedValues MotoRenewalCheckRecordExpectedValues
        {
            get
            {
                if ((this.mMotoRenewalCheckRecordExpectedValues == null))
                {
                    this.mMotoRenewalCheckRecordExpectedValues = new MotoRenewalCheckRecordExpectedValues();
                }
                return this.mMotoRenewalCheckRecordExpectedValues;
            }
        }

        public virtual MotoRegressAppParams MotoRegressAppParams
        {
            get
            {
                if ((this.mMotoRegressAppParams == null))
                {
                    this.mMotoRegressAppParams = new MotoRegressAppParams();
                }
                return this.mMotoRegressAppParams;
            }
        }

        public virtual MotoRebrokeSelectSchemeParams MotoRebrokeSelectSchemeParams
        {
            get
            {
                if ((this.mMotoRebrokeSelectSchemeParams == null))
                {
                    this.mMotoRebrokeSelectSchemeParams = new MotoRebrokeSelectSchemeParams();
                }
                return this.mMotoRebrokeSelectSchemeParams;
            }
        }

        public virtual MotoPostcodeLookupParams MotoPostcodeLookupParams
        {
            get
            {
                if ((this.mMotoPostcodeLookupParams == null))
                {
                    this.mMotoPostcodeLookupParams = new MotoPostcodeLookupParams();
                }
                return this.mMotoPostcodeLookupParams;
            }
        }

        public virtual MotoPolicyPersonParams MotoPolicyPersonParams
        {
            get
            {
                if ((this.mMotoPolicyPersonParams == null))
                {
                    this.mMotoPolicyPersonParams = new MotoPolicyPersonParams();
                }
                return this.mMotoPolicyPersonParams;
            }
        }

        public virtual MotoMTANoSaveParams MotoMTANoSaveParams
        {
            get
            {
                if ((this.mMotoMTANoSaveParams == null))
                {
                    this.mMotoMTANoSaveParams = new MotoMTANoSaveParams();
                }
                return this.mMotoMTANoSaveParams;
            }
        }

        public virtual MotoMTAMessageCancelledExpectedValues MotoMTAMessageCancelledExpectedValues
        {
            get
            {
                if ((this.mMotoMTAMessageCancelledExpectedValues == null))
                {
                    this.mMotoMTAMessageCancelledExpectedValues = new MotoMTAMessageCancelledExpectedValues();
                }
                return this.mMotoMTAMessageCancelledExpectedValues;
            }
        }

        public virtual MotoMTAMessageAfterDateExpectedValues MotoMTAMessageAfterDateExpectedValues
        {
            get
            {
                if ((this.mMotoMTAMessageAfterDateExpectedValues == null))
                {
                    this.mMotoMTAMessageAfterDateExpectedValues = new MotoMTAMessageAfterDateExpectedValues();
                }
                return this.mMotoMTAMessageAfterDateExpectedValues;
            }
        }

        public virtual MotoMTAConfirmPolicyParams MotoMTAConfirmPolicyParams
        {
            get
            {
                if ((this.mMotoMTAConfirmPolicyParams == null))
                {
                    this.mMotoMTAConfirmPolicyParams = new MotoMTAConfirmPolicyParams();
                }
                return this.mMotoMTAConfirmPolicyParams;
            }
        }

        public virtual MotoMTACheckNewValueExpectedValues MotoMTACheckNewValueExpectedValues
        {
            get
            {
                if ((this.mMotoMTACheckNewValueExpectedValues == null))
                {
                    this.mMotoMTACheckNewValueExpectedValues = new MotoMTACheckNewValueExpectedValues();
                }
                return this.mMotoMTACheckNewValueExpectedValues;
            }
        }

        public virtual MotoMTACheckCarExpectedValues MotoMTACheckCarExpectedValues
        {
            get
            {
                if ((this.mMotoMTACheckCarExpectedValues == null))
                {
                    this.mMotoMTACheckCarExpectedValues = new MotoMTACheckCarExpectedValues();
                }
                return this.mMotoMTACheckCarExpectedValues;
            }
        }

        public virtual MotoMTABeforeFinishParams MotoMTABeforeFinishParams
        {
            get
            {
                if ((this.mMotoMTABeforeFinishParams == null))
                {
                    this.mMotoMTABeforeFinishParams = new MotoMTABeforeFinishParams();
                }
                return this.mMotoMTABeforeFinishParams;
            }
        }

        public virtual MotoMTABeforeAcceptParams MotoMTABeforeAcceptParams
        {
            get
            {
                if ((this.mMotoMTABeforeAcceptParams == null))
                {
                    this.mMotoMTABeforeAcceptParams = new MotoMTABeforeAcceptParams();
                }
                return this.mMotoMTABeforeAcceptParams;
            }
        }

        public virtual MotoMTABefore2Params MotoMTABefore2Params
        {
            get
            {
                if ((this.mMotoMTABefore2Params == null))
                {
                    this.mMotoMTABefore2Params = new MotoMTABefore2Params();
                }
                return this.mMotoMTABefore2Params;
            }
        }

        public virtual MotoMTABeforeParams MotoMTABeforeParams
        {
            get
            {
                if ((this.mMotoMTABeforeParams == null))
                {
                    this.mMotoMTABeforeParams = new MotoMTABeforeParams();
                }
                return this.mMotoMTABeforeParams;
            }
        }

        public virtual MotoMTAAcceptParams MotoMTAAcceptParams
        {
            get
            {
                if ((this.mMotoMTAAcceptParams == null))
                {
                    this.mMotoMTAAcceptParams = new MotoMTAAcceptParams();
                }
                return this.mMotoMTAAcceptParams;
            }
        }

        public virtual MotoInceptionDateParams MotoInceptionDateParams
        {
            get
            {
                if ((this.mMotoInceptionDateParams == null))
                {
                    this.mMotoInceptionDateParams = new MotoInceptionDateParams();
                }
                return this.mMotoInceptionDateParams;
            }
        }

        public virtual MotoFinishMTAParams MotoFinishMTAParams
        {
            get
            {
                if ((this.mMotoFinishMTAParams == null))
                {
                    this.mMotoFinishMTAParams = new MotoFinishMTAParams();
                }
                return this.mMotoFinishMTAParams;
            }
        }

        /// <summary>
        ///     MTAEffectiveDate - Use 'MTAEffectiveDateParams' to pass parameters into this method.
        /// </summary>
        public void MTAEffectiveDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '31/10/12' in 'Unknown Name' text box
            uIItemEdit.Text = this.MTAEffectiveDateParams.UIItemEditText;
        }

        /// <summary>
        ///     MotoGetPolicyNumber
        /// </summary>
        public string MotoGetPolicyNumber()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Click 'Unknown Name' text box
            return uIItemEdit.GetProperty("Text").ToString();
        }

        /// <summary>
        ///     MotoCreateSiteRenewal - Use 'MotoCreateSiteRenewalParams' to pass parameters into this method.
        /// </summary>
        public void MotoCreateSiteRenewal()
        {
            #region Variable Declarations

            HtmlHyperlink uICreateaMotorTestReneHyperlink =
                this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument1.UIDivRenewalsPane.UICreateaMotorTestReneHyperlink;
            HtmlComboBox uIInsurerIDComboBox = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPolicyNumberEdit;
            HtmlEdit uITxtAutoLapseDateEdit1 = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtAutoLapseDateEdit1;
            HtmlInputButton uICreateRecordButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.UIInsurEcomSystemMaintWindow;
            HtmlEdit uITxtRenewalDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;

            #endregion

            // Click 'Create a Motor Test Renewal Invitation' link
            Mouse.Click(uICreateaMotorTestReneHyperlink, new Point(50, 22));

            // Select 'Highway Insurance' in 'InsurerID' combo box
            uIInsurerIDComboBox.SelectedItem = this.MotoCreateSiteRenewalParams.UIInsurerIDComboBoxSelectedItem;

            // Type '7071000841' in 'txtPolicyNumber' text box
            uITxtPolicyNumberEdit.Text = this.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText;

            // Type '12/11/2012' in 'txtAutoLapseDate' text box
            uITxtAutoLapseDateEdit1.Text = uITxtRenewalDateEdit.GetProperty("Text").ToString();

            // Click 'Create Record' button
            Mouse.Click(uICreateRecordButton, new Point(112, 11));

            // Click 'Ok' button in the browser dialog window
            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        /// <summary>
        ///     _
        ///     GetCustomerCode
        /// </summary>
        public string GetCustomerCode()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UICUSTOMERSWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click 'Cancel' button
            //  Mouse.Click(uICancelButton, new Point(42, 10));

            return uIItemEdit.GetProperty("Text").ToString();

            // Click 'Unknown Name' text box
            //Mouse.Click(uIItemEdit, new Point(83, 7));
        }

        /// <summary>
        ///     CloseDemandsMoto
        /// </summary>
        public void CloseDemandsMoto()
        {
            #region Variable Declarations

            WinClient UIDemandsNeedsMotorComClient = this.UIDemandsNeedsMotorComWindow.UIDemandsNeedsMotorComClient;

            #endregion

            // Click 'Close' button
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(UIDemandsNeedsMotorComClient, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void etam_ok()
        {
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIOKButton1, new Point(47, 12));
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void QuoteSelectListCancel()
        {
            WinButton uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uICancelButton, new Point(14, 18));
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     OpenBrowser2 - Use 'OpenBrowser2Params' to pass parameters into this method.
        /// </summary>
        public void OpenBrowser2()
        {
            #region Variable Declarations

            WinButton ok_but_xp = this.UIWindowsSecurityWindow1.UIWindowsSecurityPane.UIOKButton;
            HtmlHyperlink uIRenewalsMaintenanceHyperlink = this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIRenewalsMaintenanceHyperlink;
            WinWindow w_xp = this.UIWindowsSecurityWindow1;
            WinButton ok_but_7 = this.UIWindowsSecurityWindow.UIWindowsSecurityPane.UIOKButton;
            WinWindow w_7 = this.UIWindowsSecurityWindow;
            WinButton ok_but;
            WinWindow w;

            #endregion

            // Go to web page 'https://www.insur-econnect.com/sysmaint/default.asp?mode=1' using new browser instance
            this.UIInsurEcomSystemMaintWindow.LaunchUrl(new Uri(this.OpenBrowser2Params.UIInsurEcomSystemMaintWindowUrl));

            if (w_xp.Exists)
            {
                ok_but = ok_but_xp;
                w = w_xp;
            }
            else
            {
                ok_but = ok_but_7;
                w = w_7;
            }

            Playback.PlaybackSettings.ContinueOnError = true;

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Keyboard.SendKeys(w, "Bus Sys{Tab}Tottenham1");

            // Click 'OK' button
            Mouse.Click(ok_but, new Point(31, 14));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Renewals Maintenance' link
            Mouse.Click(uIRenewalsMaintenanceHyperlink, new Point(39, 7));
        }

        /// <summary>
        ///     CloseBrowser
        /// </summary>
        public void CloseBrowser()
        {
            #region Variable Declarations

            WinButton uICloseButton = this.UIBlankPageMicrosoftInWindow.UIBlankPageWindowsInteTitleBar.UICloseButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)

            // Click 'Close' button
            // Mouse.Click(uICloseButton, new Point(31, 0));
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(this.UIBlankPageMicrosoftInWindow, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
            // Reset flag to ensure that play back stops if there is an error.
        }

        /// <summary>
        ///     HomeFinishQuote - Use 'HomeFinishQuoteParams' to pass parameters into this method.
        /// </summary>
        public void HomeFinishQuote()
        {
            #region Variable Declarations

            WinButton uILookupButton = this.UIPolicyDetailConfirmaWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinButton uIConfirmButton = this.UIPolicyDetailConfirmaWindow.UIConfirmWindow.UIConfirmButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(23, 12));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(46, 14));

            // Click '&Confirm' button
            Mouse.Click(uIConfirmButton, new Point(25, 11));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(27, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeFinishQuoteParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(61, 11));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeFinishQuoteParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(51, 10));

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(50, 10));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(50, 10));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(44, 10));
        }

        /// <summary>
        ///     MotoAWAP - Use 'MotoAWAPParams' to pass parameters into this method.
        /// </summary>
        public void MotoAWAP()
        {
            #region Variable Declarations

            WinButton uIAWAPButton = this.UIQuoteResultsWindow.UIAWAPWindow.UIAWAPButton;
            WinComboBox uIItemComboBox = this.UIAcceptWithAnotherProWindow.UIItemWindow.UIItemComboBox;
            WinEdit uIItemEdit = this.UIAcceptWithAnotherProWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIAcceptWithAnotherProWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIAcceptWithAnotherProWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIAcceptWithAnotherProWindow.UIItemWindow4.UIItemEdit;
            WinButton uIOKButton = this.UIAcceptWithAnotherProWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton4 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&AWAP' button
            Mouse.Click(uIAWAPButton, new Point(50, 14));

            // Select 'AIG' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.MotoAWAPParams.UIItemComboBoxSelectedItem;

            // Type 'test' in 'Unknown Name' text box
            uIItemEdit.Text = this.MotoAWAPParams.UIItemEditText;

            // Type '12345' in 'Unknown Name' text box
            uIItemEdit1.Text = this.MotoAWAPParams.UIItemEditText1;

            // Type '10000' in 'Unknown Name' text box
            uIItemEdit2.Text = this.MotoAWAPParams.UIItemEditText2;

            // Click 'Unknown Name' text box
            Mouse.Click(uIItemEdit3, new Point(31, 6));

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(49, 9));

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(45, 11));

            // The recording for the application under test '\\Pc-pez\APPLIED\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAWAPParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(44, 7));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(56, 6));
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIOKButton3, new Point(56, 6));
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(47, 13));
        }

        /// <summary>
        ///     MotoAmendRiskRenew - Use 'MotoAmendRiskRenewParams' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRiskRenew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton5 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton6 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton1 = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(53, 14));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(54, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(62, 10));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(42, 10));

            this.RetrieveResponse();

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoAmendRiskRenewParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(58, 18));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(48, 11));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAmendRiskRenewParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(54, 5));

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(45, 10));

            // Select 'AG Administrator General' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.MotoAmendRiskRenewParams.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton5, new Point(52, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton6, new Point(49, 16));

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(48, 12));

            // Click '&Yes' button
            Mouse.Click(uIYesButton1, new Point(19, 10));
        }

        /// <summary>
        ///     MotoAmendRiskNew_1 - Use 'MotoAmendRiskNew_1Params' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRiskNew_1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoAmendRiskNew_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(59, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(54, 6));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(50, 20));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAmendRiskNew_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(47, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(55, 14));

            // Select 'AG Administrator General' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.MotoAmendRiskNew_1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(56, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(48, 12));

            this.etam_ok();

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(47, 18));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 7));
        }

        /// <summary>
        ///     RenewalModuleInvite_1 - Use 'RenewalModuleInvite_1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleInvite_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(50, 16));

            this.RetrieveResponse();

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.RenewalModuleInvite_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(72, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.RenewalModuleInvite_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(24, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(35, 10));
        }

        /// <summary>
        ///     HighlightCustomer
        /// </summary>
        public void HighlightCustomer()
        {
            #region Variable Declarations

            WinClient uICUSTOMERSClient = this.UIPolicyautotestWindow.UICUSTOMERSWindow.UIItemWindow1.UICUSTOMERSClient;

            #endregion

            // Click 'CUSTOMERS' client
            Mouse.Click(uICUSTOMERSClient, new Point(31, 25));
            Mouse.Click(uICUSTOMERSClient, new Point(31, 25));
        }

        /// <summary>
        ///     HomePrintQuote_1 - Use 'HomePrintQuote_1Params' to pass parameters into this method.
        /// </summary>
        public void HomePrintQuote_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinButton uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinButton uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinButton uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIQuotesResultsClient;
            WinButton uIPrintQuoteButton = this.UIQuotesResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(40, 5));

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(31, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(39, 17));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(39, 17));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(9, 9));

            this.PublicCreditCheckOk();

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(526, 161));

            // Type '{End}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomePrintQuote_1Params.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Click '&Print Quote..' button
            Mouse.Click(uIPrintQuoteButton, new Point(65, 11));
        }

        /// <summary>
        ///     HomeExitWithPolicy - Use 'HomeExitWithPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeExitWithPolicy()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;
            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinButton uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinButton uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinButton uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIQuotesResultsClient;
            WinButton uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton1 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton2 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uICancelButton1 = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenHOMEWindow1.UIItemWindow.UIItemEdit;
            WinButton uIOKButton3 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UISelectTaminsurerforiClient.UIOKButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(41, 14));

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(49, 4));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(89, 11));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(33, 10));

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(38, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(46, 13));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(46, 13));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(48, 3));

            this.PublicCreditCheckOk();

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(500, 164));

            // Type '{Home}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeExitWithPolicyParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Double-Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(46, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 13));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeExitWithPolicyParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(45, 15));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(42, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(55, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton1, new Point(37, 17));

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton, new Point(28, 18));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(29, 11));

            // Click 'Unknown Name' text box
            Mouse.Click(uIItemEdit, new Point(22, 8));
        }

        /// <summary>
        ///     HomeAcceptPolicy - Use 'HomeAcceptPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeAcceptPolicy()
        {
            #region Variable Declarations

            WinButton uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIBrokerAddonsWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIPolicyDetailConfirmaWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click 'Accept' button
            Mouse.Click(uIAcceptButton, new Point(47, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(49, 11));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(30, 14));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(41, 9));

            // Reset flag to ensure that play back stops if there is an error.

            Playback.PlaybackSettings.ContinueOnError = false;

            this.etam_ok();

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(47, 22));

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(46, 11));

            // Type 'B338TH' in 'Unknown Name' text box
            uIItemEdit.Text = this.HomeAcceptPolicyParams.UIItemEditText;
        }

        /// <summary>
        ///     CloseLogin
        /// </summary>
        public void CloseLogin()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UISignonErrorWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = this.UITheAgencyManagerSignWindow.UIOKWindow.UICancelButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 11));

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(50, 13));
        }

        /// <summary>
        ///     AcceptQuote
        /// </summary>
        public void AcceptQuote()
        {
            #region Variable Declarations

            WinButton uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;

            #endregion

            // Wait for 3 seconds for user delay between actions; Click 'A&ccept' button
            Playback.Wait(3000);
            Mouse.Click(uIAcceptButton, new Point(70, 7));
        }

        /// <summary>
        ///     AddPolicy - Use 'AddPolicyParams' to pass parameters into this method.
        /// </summary>
        public void AddPolicy()
        {
            #region Variable Declarations

            WinButton uIClientsFilesButton = this.UITheAgencyManagerWindow1.UIClientsFilesWindow.UIClientsFilesButton;
            WinComboBox uIItemComboBox = this.UICustomertxt1tdsfsWindow.UICUSTOMERSWindow.UIItemWindow.UIItemComboBox;
            WinButton uIAddButton = this.UICustomertxt1tdsfsWindow.UIAddWindow.UIAddButton;
            WinRadioButton uIPersonalLinesRadioButton = this.UIAssignClientNumberWindow.UIPersonalLinesWindow.UIPersonalLinesRadioButton;
            WinEdit uIItemEdit = this.UIAssignClientNumberWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.UIAssignClientNumberWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.UIVerifyWindow.UIYesWindow.UIYesButton;
            WinEdit uIItemEdit1 = this.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIItemWindow1.UIItemEdit;
            WinButton uIOKButton1 = this.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIOKWindow.UIOKButton;
            WinButton uIItemButton = this.UICustomertxt1tdsfsWindow.UIItemWindow.UIItemButton;
            WinButton uIOKButton2 = this.UISelectaPolicyNumberWindow.UIOKWindow.UIOKButton;
            WinWindow uIItemWindow = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow.UIItemClient.UIItemWindow;

            #endregion

            // Click 'Clients && Files' button
            Mouse.Click(uIClientsFilesButton, new Point(38, 30));

            // Select 'Customers' in combo box
            uIItemComboBox.SelectedItem = this.AddPolicyParams.UIItemComboBoxSelectedItem;

            // Click 'Add' button
            Mouse.Click(uIAddButton, new Point(175, 7));

            // Type 'autotest' in '&Personal Lines' radio button
            Keyboard.SendKeys(uIPersonalLinesRadioButton, this.AddPolicyParams.UIPersonalLinesRadioButtonSendKeys, ModifierKeys.None);

            // Type 'autotest' in text box
            uIItemEdit.Text = this.AddPolicyParams.UIItemEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(41, 15));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(44, 11));

            // Type '1' in text box
            uIItemEdit1.Text = this.AddPolicyParams.UIItemEditText1;

            // Type '1' in text box
            uIItemEdit2.Text = this.AddPolicyParams.UIItemEditText2;

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(24, 17));

            // Click button
            Mouse.Click(uIItemButton, new Point(10, 15));

            // Click 'Add' button
            Mouse.Click(uIAddButton, new Point(94, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(37, 13));

            // Click window
            Mouse.Click(uIItemWindow, new Point(21, 18));
        }

        /// <summary>
        ///     HomeCheckPremium - Use 'HomeCheckPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box is not equal to '0.00'
            Assert.AreNotEqual(this.HomeCheckPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeCheckPrint - Use 'HomeCheckPrintExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckPrint()
        {
            #region Variable Declarations

            HtmlCell uIItem1989Cell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIItem1989Cell;
            HtmlCell uIMrTestTestCell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIMrTestTestCell;

            #endregion

            // Verify that the 'InnerText' property of '1989' cell equals '1989'
            Assert.AreEqual(this.HomeCheckPrintExpectedValues.UIItem1989CellInnerText, uIItem1989Cell.InnerText);

            // Verify that the 'InnerText' property of 'Mr Test Test' cell equals 'Mr Test Test'
            Assert.AreEqual(this.HomeCheckPrintExpectedValues.UIMrTestTestCellInnerText, uIMrTestTestCell.InnerText);
        }

        /// <summary>
        ///     HomeCheckStatus - Use 'HomeCheckStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow1.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'NEW'
            Assert.AreEqual(this.HomeCheckStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeCheckZeroPremium - Use 'HomeCheckZeroPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckZeroPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '0.00'
            Assert.AreEqual(this.HomeCheckZeroPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeClickPremium
        /// </summary>
        public void HomeClickPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click text box
            Mouse.Click(uIItemEdit, new Point(24, 5));
        }

        /// <summary>
        ///     HomeCloseOpenPolicy
        /// </summary>
        public void HomeCloseOpenPolicy()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(33, 16));

            // Click button
            Mouse.Click(uIItemButton, new Point(18, 20));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(44, 16));
        }

        /// <summary>
        ///     HomeCloseOpenPolicyList
        /// </summary>
        public void HomeCloseOpenPolicyList()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(47, 19));

            // Click button
            Mouse.Click(uIItemButton, new Point(21, 14));
        }

        /// <summary>
        ///     HomeClosePilicy
        /// </summary>
        public void HomeClosePilicy()
        {
            #region Variable Declarations

            WinButton uICloseButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow.UICloseButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Close' button
            Mouse.Click(uICloseButton, new Point(33, 13));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 14));
        }

        /// <summary>
        ///     HomeCopyCheckData - Use 'HomeCopyCheckDataExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCopyCheckData()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow21.UIItemComboBox;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow6.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'Test'
            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'SelectedItem' property of combo box equals 'Account Director'
            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemComboBoxSelectedItem, uIItemComboBox.SelectedItem);

            // Verify that the 'Text' property of text box equals 'B33 8TH'
            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            // Verify that the 'Text' property of text box equals '533 Yardley Green Road'
            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText2, uIItemEdit2.Text);
        }

        /// <summary>
        ///     HomeCopyRisk - Use 'HomeCopyRiskParams' to pass parameters into this method.
        /// </summary>
        public void HomeCopyRisk()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = this.UIWhichpolicywouldyoulWindow.UIItemWindow.UIWhichpolicywouldyoulClient.UIOKButton;
            WinRadioButton uIHouseholdRadioButton = this.UIProductSelectionWindow.UIHouseholdWindow.UIHouseholdRadioButton;
            WinButton uIOKButton1 = this.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(26, 9));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Copy Risk' menu item
            Mouse.Click(uICopyRiskMenuItem, new Point(93, 8));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(54, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Select 'Household' radio button
            uIHouseholdRadioButton.Selected = this.HomeCopyRiskParams.UIHouseholdRadioButtonSelected;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(42, 21));
        }

        /// <summary>
        ///     HomeCheckPolicyPremium - Use 'HomeCheckPolicyPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckPolicyPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box is not equal to '0.00'
            Assert.AreNotEqual(this.HomeCheckPolicyPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeDemands
        /// </summary>
        public void HomeDemands()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uIDemandsNeedsButton = this.UIQuotesResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(36, 9));

            // Click 'Demands && Needs' button
            Mouse.Click(uIDemandsNeedsButton, new Point(59, 13));
        }

        /// <summary>
        ///     HomeExitWithoutPolicy - Use 'HomeExitWithoutPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeExitWithoutPolicy()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton1 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UISelectTaminsurerforiClient.UIOKButton;
            WinButton uIOKButton2 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(54, 9));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(45, 6));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeExitWithoutPolicyParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(30, 15));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(42, 10));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(70, 14));
        }

        /// <summary>
        ///     HomeMTAAccept
        /// </summary>
        public void HomeMTAAccept()
        {
            #region Variable Declarations

            WinButton uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinButton uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinButton uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinButton uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;

            #endregion

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(39, 12));

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(47, 12));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(47, 12));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(47, 12));

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(47, 12));

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(47, 12));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(47, 12));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(47, 12));
        }

        /// <summary>
        ///     HomeMTAAfter
        /// </summary>
        public void HomeMTAAfter()
        {
            #region Variable Declarations

            WinButton uIAfterButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&After' button
            Mouse.Click(uIAfterButton, new Point(38, 10));
        }

        /// <summary>
        ///     HomeMTABefore
        /// </summary>
        public void HomeMTABefore()
        {
            #region Variable Declarations

            WinButton uIBeforeButton = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Before' button
            Mouse.Click(uIBeforeButton, new Point(27, 12));
        }

        /// <summary>
        ///     HomeMTACancel
        /// </summary>
        public void HomeMTACancel()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow.UICancelButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(42, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(35, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(46, 14));
        }

        /// <summary>
        ///     HomeMTACancel1
        /// </summary>
        public void HomeMTACancel1()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow2.UICancelButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(37, 17));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(66, 11));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 13));
        }

        /// <summary>
        ///     HomeMTAChange - Use 'HomeMTAChangeParams' to pass parameters into this method.
        /// </summary>
        public void HomeMTAChange()
        {
            #region Variable Declarations

            WinButton uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow1.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Click '&MTA' button
            Mouse.Click(uIMTAButton, new Point(45, 12));

            // Select 'General Adjustment' in combo box
            uIItemComboBox.SelectedItem = this.HomeMTAChangeParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(35, 15));

            // Type 'NewTest' in text box
            uIItemEdit.Text = this.HomeMTAChangeParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeMTACheckCancelled - Use 'HomeMTACheckCancelledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACheckCancelled()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'Test'
            Assert.AreEqual(this.HomeMTACheckCancelledExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeMTACheckChanged - Use 'HomeMTACheckChangedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACheckChanged()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'NewTest'
            Assert.AreEqual(this.HomeMTACheckChangedExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeMTACheckMessage - Use 'HomeMTACheckMessageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACheckMessage()
        {
            #region Variable Declarations

            WinText uIDateBeforeCurrentMTAText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            #endregion

            // Verify that the 'DisplayText' property of 'Date Before Current MTA Effective Date - Please en...' label equals 'Date Before Current MTA Effective Date - Please enter Adjustment Date.'
            Assert.AreEqual(this.HomeMTACheckMessageExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText);
        }

        /// <summary>
        ///     HomeMTACloseMessage
        /// </summary>
        public void HomeMTACloseMessage()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(52, 7));
        }

        /// <summary>
        ///     HomeMTACopyCheck - Use 'HomeMTACopyCheckExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACopyCheck()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow6.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow31.UIItemComboBox;

            #endregion

            // Verify that the 'Text' property of text box equals 'NewTest'
            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals 'B33 8TH'
            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            // Verify that the 'Text' property of text box equals '533 Yardley Green Road'
            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemEditText2, uIItemEdit2.Text);

            // Verify that the 'SelectedItem' property of combo box equals 'Advertising'
            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemComboBoxSelectedItem, uIItemComboBox.SelectedItem);
        }

        /// <summary>
        ///     AmendDateBeforeMessage - Use 'AmendDateBeforeMessageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AmendDateBeforeMessage()
        {
            #region Variable Declarations

            WinText uIDateBeforeInceptionDText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeInceptionDText;

            #endregion

            // Verify that the 'DisplayText' property of 'Date Before Inception Date - Please enter Adjustme...' label equals 'Date Before Inception Date - Please enter Adjustment Date.'
            Assert.AreEqual(this.AmendDateBeforeMessageExpectedValues.UIDateBeforeInceptionDTextDisplayText, uIDateBeforeInceptionDText.DisplayText);
        }

        /// <summary>
        ///     HomeAddressLookup - Use 'HomeAddressLookupExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeAddressLookup()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow6.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow7.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '533 Yardley Green Road'
            Assert.AreEqual(this.HomeAddressLookupExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals 'BIRMINGHAM'
            Assert.AreEqual(this.HomeAddressLookupExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     HomeAcceptQuote_1 - Use 'HomeAcceptQuote_1Params' to pass parameters into this method.
        /// </summary>
        public void HomeAcceptQuote_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIBrokerAddonsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIPolicyDetailConfirmaWindow.UIItemWindow.UIItemEdit;
            WinButton uILookupButton = this.UIPolicyDetailConfirmaWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton3 = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinButton uIConfirmButton = this.UIPolicyDetailConfirmaWindow.UIConfirmWindow.UIConfirmButton;
            WinButton uIOKButton4 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton5 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton6 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton7 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton8 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(35, 13));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(35, 17));

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(29, 10));

            // Type 'B338TH' in text box
            uIItemEdit.Text = this.HomeAcceptQuote_1Params.UIItemEditText;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(25, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(20, 19));

            // Click '&Confirm' button
            Mouse.Click(uIConfirmButton, new Point(26, 9));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(46, 12));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeAcceptQuote_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton5, new Point(60, 10));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeAcceptQuote_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton6, new Point(40, 8));

            // Click '&Ok' button
            Mouse.Click(uIOKButton7, new Point(54, 8));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton7, new Point(40, 18));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'OK' button
            Mouse.Click(uIOKButton8, new Point(43, 20));
        }

        /// <summary>
        ///     ExitEnabled - Use 'ExitEnabledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ExitEnabled()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            #endregion

            // Verify that the 'Enabled' property of 'E&xit' button equals 'True'
            Assert.AreEqual(this.ExitEnabledExpectedValues.UIExitButtonEnabled, uIExitButton.Enabled);
        }

        /// <summary>
        ///     FinishQuote1 - Use 'FinishQuote1Params' to pass parameters into this method.
        /// </summary>
        public void FinishQuote1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton1 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton2 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton3 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.FinishQuote1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(51, 7));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.FinishQuote1Params.UIAddActivityCheckBoxChecked;

            // Wait for 2 seconds for user delay between actions; Click 'Ok' button
            Playback.Wait(2000);
            Mouse.Click(uIOKButton1, new Point(41, 15));

            // Click '&Ok' button
            Mouse.Click(uIOKButton2, new Point(42, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(47, 19));
        }

        /// <summary>
        ///     FinishQuote
        /// </summary>
        public void FinishQuote()
        {
            #region Variable Declarations

            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIConfirmButton = this.UIPolicyDateTimeWindow.UIConfirmWindow.UIConfirmButton;

            #endregion

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(35, 8));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(40, 10));

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(54, 10));

            // Click '&Confirm' button
            Mouse.Click(uIConfirmButton, new Point(37, 24));
        }

        /// <summary>
        ///     Exit1 - Use 'Exit1Params' to pass parameters into this method.
        /// </summary>
        public void Exit1()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton1 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            #endregion

            // Wait for 5 seconds for user delay between actions; Click 'E&xit' button
            Playback.Wait(5000);
            Mouse.Click(uIExitButton, new Point(46, 12));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(39, 9));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.Exit1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(34, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(52, 14));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(23, 19));

            // Click button
            Mouse.Click(uIItemButton, new Point(19, 14));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(44, 15));
        }

        /// <summary>
        ///     etam_yes
        /// </summary>
        public void etam_yes()
        {
            #region Variable Declarations

            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(42, 12));
        }

        /// <summary>
        ///     DemandsAndNeeds
        /// </summary>
        public void DemandsAndNeeds()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uIDemandsNeedsButton = this.UIQuoteResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(31, 11));

            // Click 'Demands && Needs' button
            Mouse.Click(uIDemandsNeedsButton, new Point(47, 12));
        }

        /// <summary>
        ///     CoverDateBackCheck - Use 'CoverDateBackCheckExpectedValues' to pass parameters into this method.
        /// </summary>
        public void CoverDateBackCheck()
        {
            #region Variable Declarations

            WinText uICoverCantBeBackDatedText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UICoverCantBeBackDatedText;

            #endregion

            // Verify that the 'DisplayText' property of 'Cover Cant Be Back Dated - Please enter Adjustment...' label equals 'Cover Cant Be Back Dated - Please enter Adjustment Date.'
            Assert.AreEqual(this.CoverDateBackCheckExpectedValues.UICoverCantBeBackDatedTextDisplayText, uICoverCantBeBackDatedText.DisplayText);
        }

        /// <summary>
        ///     ConfirmDocuments
        /// </summary>
        public void ConfirmDocuments()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(33, 16));
        }

        /// <summary>
        ///     CloseRegressApp
        /// </summary>
        public void CloseRegressApp()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIRegressIETamPolicyWindow.UIExitWindow.UIExitButton;

            #endregion

            // Click 'Exit' button
            Mouse.Click(uIExitButton, new Point(35, 20));
        }

        /// <summary>
        ///     ClosePolicy
        /// </summary>
        public void ClosePolicy()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(46, 7));
        }

        /// <summary>
        ///     CheckAutoPrint - Use 'CheckAutoPrintExpectedValues' to pass parameters into this method.
        /// </summary>
        public void CheckAutoPrint()
        {
            #region Variable Declarations

            HtmlCell uIFORDFIESTABLACK16V13Cell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable.UIFORDFIESTABLACK16V13Cell;

            #endregion

            // Verify that the 'InnerText' property of 'FORD FIESTA BLACK 16V (1388cc) 2003-2003' cell contains 'FORD FIESTA BLACK 16V'
            StringAssert.Contains(uIFORDFIESTABLACK16V13Cell.InnerText, this.CheckAutoPrintExpectedValues.UIFORDFIESTABLACK16V13CellInnerText);
        }

        /// <summary>
        ///     ChangePremium - Use 'ChangePremiumParams' to pass parameters into this method.
        /// </summary>
        public void ChangePremium()
        {
            #region Variable Declarations

            WinButton uIPremiumButton = this.UIQuoteResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = this.UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinButton uIOKButton = this.UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Premium' button
            Mouse.Click(uIPremiumButton, new Point(23, 7));

            // Type '10000' in text box
            uIItemEdit.Text = this.ChangePremiumParams.UIItemEditText;

            // Type '321412341' in text box
            uIItemEdit1.Text = this.ChangePremiumParams.UIItemEditText1;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(25, 6));
        }

        /// <summary>
        ///     ChangeDatePolicy - Use 'ChangeDatePolicyParams' to pass parameters into this method.
        /// </summary>
        public void ChangeDatePolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow3.UIItemEdit;
            WinButton uIOKButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '05/11/2011' in text box
            uIItemEdit.Text = this.ChangeDatePolicyParams.UIItemEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 17));
        }

        /// <summary>
        ///     CancelPrint
        /// </summary>
        public void CancelPrint()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(65, 12));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     CancelFilter
        /// </summary>
        public void CancelFilter()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(42, 8));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     Calculate
        /// </summary>
        public void Calculate()
        {
            #region Variable Declarations

            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(68, 8));
        }

        /// <summary>
        ///     AssertSelectPolicyForm - Use 'AssertSelectPolicyFormExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertSelectPolicyForm()
        {
            #region Variable Declarations

            WinWindow uIQuoteResultsWindow = this.UIQuoteResultsWindow;

            #endregion

            // Verify that the 'Name' property of 'Quote Results' window equals 'Quote Results'
            Assert.AreEqual(this.AssertSelectPolicyFormExpectedValues.UIQuoteResultsWindowName, uIQuoteResultsWindow.Name);
        }

        /// <summary>
        ///     AssertMethod3 - Use 'AssertMethod3ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod3()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'RF53OXL'
            Assert.AreEqual(this.AssertMethod3ExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '1000'
            Assert.AreEqual(this.AssertMethod3ExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '0.00'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box is not equal to '0.00'
            Assert.AreNotEqual(this.AssertMethod1ExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     AmendSelectQuote - Use 'AmendSelectQuoteParams' to pass parameters into this method.
        /// </summary>
        public void AmendSelectQuote()
        {
            #region Variable Declarations

            WinClient uIAmendRiskResultsClient = this.UIAmendRiskResultsWindow.UIItemWindow.UIAmendRiskResultsClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Amend Risk Results' client
            Mouse.Click(uIAmendRiskResultsClient, new Point(362, 136));

            // Type '{Home}' in 'Amend Risk Results' client
            Keyboard.SendKeys(uIAmendRiskResultsClient, this.AmendSelectQuoteParams.UIAmendRiskResultsClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeRebrokeSelectAlternative
        /// </summary>
        public void HomeRebrokeSelectAlternative()
        {
            #region Variable Declarations

            WinButton uISelectAlternativeButton = this.UIHouseholdRebrokeResuWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            #endregion

            // Click '&Select Alternative' button
            Mouse.Click(uISelectAlternativeButton, new Point(49, 13));
        }

        /// <summary>
        ///     HomeRebrokeFinish
        /// </summary>
        public void HomeRebrokeFinish()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(36, 13));
        }

        /// <summary>
        ///     HomeRebrokeCurrent
        /// </summary>
        public void HomeRebrokeCurrent()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(60, 9));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(63, 11));
        }

        /// <summary>
        ///     HomeRebroke
        /// </summary>
        public void HomeRebroke()
        {
            #region Variable Declarations

            WinButton uIRebrokeButton = this.UIAUTO2301001Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Re&broke...' button
            Mouse.Click(uIRebrokeButton, new Point(55, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(41, 15));

            // Click 'Proceed' button
            Mouse.Click(uIProceedButton, new Point(61, 11));
        }

        /// <summary>
        ///     HomeProposer - Use 'HomeProposerParams' to pass parameters into this method.
        /// </summary>
        public void HomeProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow11.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow21.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow31.UIItemComboBox;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinButton uILookupButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type 'test1' in text box
            uIItemEdit.Text = this.HomeProposerParams.UIItemEditText;

            // Type 'test' in text box
            uIItemEdit1.Text = this.HomeProposerParams.UIItemEditText1;

            // Type 'test' in text box
            uIItemEdit.Text = this.HomeProposerParams.UIItemEditText2;

            // Select 'Account Director' in combo box
            uIItemComboBox.SelectedItem = this.HomeProposerParams.UIItemComboBoxSelectedItem;

            // Select 'Advertising' in combo box
            uIItemComboBox1.SelectedItem = this.HomeProposerParams.UIItemComboBoxSelectedItem1;

            // Type '160589' in text box
            uIItemEdit2.Text = this.HomeProposerParams.UIItemEditText3;

            // Click text box
            Mouse.Click(uIItemEdit3, new Point(48, 10));

            // Type 'B338TH' in text box
            uIItemEdit3.Text = this.HomeProposerParams.UIItemEditText4;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(28, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(43, 7));
        }

        /// <summary>
        ///     HomePrintQuote
        /// </summary>
        public void HomePrintQuote()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(19, 8));
        }

        /// <summary>
        ///     HomeOpenQuote
        /// </summary>
        public void HomeOpenQuote()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;

            #endregion

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(31, 8));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(123, 7));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(44, 13));
        }

        /// <summary>
        ///     HomeOpenPolicy
        /// </summary>
        public void HomeOpenPolicy()
        {
            #region Variable Declarations

            WinButton uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(26, 12));

            // Click text box
            Mouse.Click(uIItemEdit, new Point(25, 5));
        }

        /// <summary>
        ///     HomeMTASelectQuote - Use 'HomeMTASelectQuoteParams' to pass parameters into this method.
        /// </summary>
        public void HomeMTASelectQuote()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIQuotesResultsClient;
            WinClient uIQuotesResultsClient1 = this.UIQuotesResultsWindow.UIItemWindow2.UIQuotesResultsClient;
            WinButton uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIOKButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton3 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton4 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(424, 227));

            // Type '{Home}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient1, this.HomeMTASelectQuoteParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Click 'Accept' button
            Mouse.Click(uIAcceptButton, new Point(64, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(37, 8));

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(39, 16));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(58, 15));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeMTASelectQuoteParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(50, 8));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeMTASelectQuoteParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton4, new Point(29, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(33, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(39, 13));
        }

        /// <summary>
        ///     HomeMTAEnterDate - Use 'HomeMTAEnterDateParams' to pass parameters into this method.
        /// </summary>
        public void HomeMTAEnterDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '15/10/12' in text box
            uIItemEdit.Text = this.HomeMTAEnterDateParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeMTACoverDate
        /// </summary>
        public void HomeMTACoverDate()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(46, 8));
        }

        /// <summary>
        ///     HomeCreatePolicy - Use 'HomeCreatePolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeCreatePolicy()
        {
            #region Variable Declarations

            WinButton uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow8.UIItemEdit;
            WinButton uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow22.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow32.UIItemEdit;
            WinButton uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinEdit uIItemEdit4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow41.UIItemEdit;
            WinButton uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;

            #endregion

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(19, 6));

            // Type '1989' in text box
            uIItemEdit.Text = this.HomeCreatePolicyParams.UIItemEditText;

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(39, 18));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(39, 18));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(39, 18));

            // Type '2345' in text box
            uIItemEdit1.Text = this.HomeCreatePolicyParams.UIItemEditText1;

            // Type '2000' in text box
            uIItemEdit2.Text = this.HomeCreatePolicyParams.UIItemEditText2;

            // Type '2000' in text box
            uIItemEdit3.Text = this.HomeCreatePolicyParams.UIItemEditText3;

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(42, 17));

            // Type '2345' in text box
            uIItemEdit4.Text = this.HomeCreatePolicyParams.UIItemEditText4;

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(16, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(31, 11));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(31, 11));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(56, 12));
        }

        /// <summary>
        ///     HomeCheckNewPremium - Use 'HomeCheckNewPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckNewPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicygdfhdfdfghgdfWindow.UIBillingScreenHOMETESWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box is not equal to '0.00'
            Assert.AreNotEqual(this.HomeCheckNewPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeCheckDemands - Use 'HomeCheckDemandsExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckDemands()
        {
            #region Variable Declarations

            WinClient uIDemandsNeedsHouseholClient = this.UIDemandsNeedsHouseholWindow.UIDemandsNeedsHouseholClient;

            #endregion

            // Verify that the 'Name' property of 'Demands&Needs(HouseholdBuildings&Contents) [Compat...' client contains 'DemandsNeeds(HouseholdBuildings&Contents)'
            StringAssert.Contains(uIDemandsNeedsHouseholClient.Name, this.HomeCheckDemandsExpectedValues.UIDemandsNeedsHouseholClientName);
        }

        /// <summary>
        ///     HomeChangePremium - Use 'HomeChangePremiumParams' to pass parameters into this method.
        /// </summary>
        public void HomeChangePremium()
        {
            #region Variable Declarations

            WinButton uIPremiumButton = this.UIQuotesResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = this.UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinButton uIOKButton = this.UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Premium...' button
            Mouse.Click(uIPremiumButton, new Point(38, 11));

            // Type '10000' in text box
            uIItemEdit.Text = this.HomeChangePremiumParams.UIItemEditText;

            // Type '6515616' in text box
            uIItemEdit1.Text = this.HomeChangePremiumParams.UIItemEditText1;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(52, 15));
        }

        /// <summary>
        ///     HomeCancelPolicyQuote_1
        /// </summary>
        public void HomeCancelPolicyQuote_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = this.UIClaimsWindow.UINOWindow.UINOButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(52, 9));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(43, 18));
        }

        /// <summary>
        ///     HomeCancelPolicyQuote
        /// </summary>
        public void HomeCancelPolicyQuote()
        {
            #region Variable Declarations

            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;

            #endregion

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(41, 7));
        }

        /// <summary>
        ///     HomeCancelPolicyExit
        /// </summary>
        public void HomeCancelPolicyExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow1.UIOKButton;
            WinButton uICancelButton = this.UIOpenWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(58, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(40, 10));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(54, 12));
        }

        /// <summary>
        ///     HomeCancelPolicyAccept - Use 'HomeCancelPolicyAcceptParams' to pass parameters into this method.
        /// </summary>
        public void HomeCancelPolicyAccept()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIQuotesResultsClient;
            WinButton uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIOKButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton3 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton4 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(491, 235));

            // Type '{Home}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeCancelPolicyAcceptParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Click 'Accept' button
            Mouse.Click(uIAcceptButton, new Point(85, 15));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(65, 9));

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(39, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(47, 13));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeCancelPolicyAcceptParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(68, 12));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeCancelPolicyAcceptParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton4, new Point(42, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(23, 5));
        }

        /// <summary>
        ///     HomeCancelPolicy - Use 'HomeCancelPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeCancelPolicy()
        {
            #region Variable Declarations

            WinButton uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow1.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&MTA' button
            Mouse.Click(uIMTAButton, new Point(35, 8));

            // Select 'Cancel Cover' in combo box
            uIItemComboBox.SelectedItem = this.HomeCancelPolicyParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(31, 11));
        }

        /// <summary>
        ///     HomeCancelCopy
        /// </summary>
        public void HomeCancelCopy()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow.UICancelButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(42, 12));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(56, 7));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(31, 15));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 15));
        }

        /// <summary>
        ///     HomeAmendSelecPolicy - Use 'HomeAmendSelecPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeAmendSelecPolicy()
        {
            #region Variable Declarations

            WinClient uIHouseholdRenewalsAmeClient = this.UIHouseholdRenewalsAmeWindow1.UIItemWindow.UIHouseholdRenewalsAmeClient;

            #endregion

            // Click 'Household Renewals Amend Risk results' client
            Mouse.Click(uIHouseholdRenewalsAmeClient, new Point(337, 202));

            // Type '{Home}' in 'Household Renewals Amend Risk results' client
            Keyboard.SendKeys(uIHouseholdRenewalsAmeClient, this.HomeAmendSelecPolicyParams.UIHouseholdRenewalsAmeClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeAmendRisk - Use 'HomeAmendRiskParams' to pass parameters into this method.
        /// </summary>
        public void HomeAmendRisk()
        {
            #region Variable Declarations

            WinButton uIAmendRiskButton = this.UIAUTO2251001Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = this.UIHouseholdRenewalsAmeWindow.UIItemWindow.UIItemEdit;
            WinButton uINextButton = this.UIHouseholdRenewalsAmeWindow.UINextWindow.UINextButton;
            WinButton uINextButton1 = this.UIHouseholdRenewalsAmeWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIHouseholdRenewalsAmeWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIHouseholdRenewalsAmeWindow.UINextWindow3.UINextButton;
            WinButton uINextButton4 = this.UIHouseholdRenewalsAmeWindow.UINextWindow4.UINextButton;
            WinButton uINextButton5 = this.UIHouseholdRenewalsAmeWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIHouseholdRenewalsAmeWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIHouseholdRenewalsAmeWindow.UIQuoteWindow.UIQuoteButton;
            WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Amend Risk...' button
            Mouse.Click(uIAmendRiskButton, new Point(67, 17));

            // Type 'TestNew' in text box
            uIItemEdit.Text = this.HomeAmendRiskParams.UIItemEditText;

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(36, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(44, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(44, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(44, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(44, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(44, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(44, 13));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(44, 13));

            // Click 'Proceed' button
            Mouse.Click(uIProceedButton, new Point(59, 15));
        }

        /// <summary>
        ///     HomeAmendRenewFinish_1 - Use 'HomeAmendRenewFinish_1Params' to pass parameters into this method.
        /// </summary>
        public void HomeAmendRenewFinish_1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeAmendRenewFinish_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(74, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(47, 12));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(54, 13));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeAmendRenewFinish_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(48, 9));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(19, 12));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.HomeAmendRenewFinish_1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(13, 16));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(46, 16));
        }

        /// <summary>
        ///     HomeAmendRenewFinish
        /// </summary>
        public void HomeAmendRenewFinish()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIHouseholdRenewalsAmeWindow1.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(52, 9));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(55, 11));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(51, 11));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     HomeAmendRenew - Use 'HomeAmendRenewParams' to pass parameters into this method.
        /// </summary>
        public void HomeAmendRenew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIHouseholdRenewalsAmeWindow1.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton5 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton6 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(36, 18));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(50, 20));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(65, 18));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(26, 16));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeAmendRenewParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(74, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(64, 14));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeAmendRenewParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(60, 17));

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(21, 8));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.HomeAmendRenewParams.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton5, new Point(60, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton6, new Point(30, 15));
        }

        /// <summary>
        ///     HomeAcceptQuote
        /// </summary>
        public void HomeAcceptQuote()
        {
            #region Variable Declarations

            WinButton uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Click 'Accept' button
            Mouse.Click(uIAcceptButton, new Point(33, 15));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(39, 13));
        }

        /// <summary>
        ///     MotoCopyFinish - Use 'MotoCopyFinishParams' to pass parameters into this method.
        /// </summary>
        public void MotoCopyFinish()
        {
            #region Variable Declarations

            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinButton uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;
            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow.UIQuoteResultsClient;
            WinButton uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIConfirmButton = this.UIPolicyDateTimeWindow.UIConfirmWindow.UIConfirmButton;
            WinButton uICancelButton1 = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.UITamXMLImportCustomerWindow.UIItemWindow.UITamXMLImportCustomerClient.UIOKButton;
            WinButton uIOKButton5 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton6 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton7 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uICancelButton2 = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(91, 8));

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(46, 7));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(33, 11));

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(456, 148));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoCopyFinishParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(58, 14));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(52, 6));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(25, 19));

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(48, 11));

            // Click '&Confirm' button
            Mouse.Click(uIConfirmButton, new Point(20, 7));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton1, new Point(39, 12));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoCopyFinishParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(54, 8));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoCopyFinishParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(23, 12));

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(54, 8));

            // Click '&Ok' button
            Mouse.Click(uIOKButton5, new Point(40, 14));

            // Click '&Ok' button
            Mouse.Click(uIOKButton6, new Point(40, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton7, new Point(43, 21));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.MotoCopyFinishParams.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton6, new Point(42, 8));

            // Click 'OK' button
            Mouse.Click(uIOKButton7, new Point(43, 6));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton2, new Point(39, 13));
        }

        /// <summary>
        ///     MotoCopyCheckProposer - Use 'MotoCopyCheckProposerExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCopyCheckProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'Test'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '16 Apr 1985'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            // Verify that the 'Text' property of text box equals 'B33 8TH'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText2, uIItemEdit2.Text);

            // Verify that the 'Text' property of text box equals '533 Yardley Green Road'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText3, uIItemEdit3.Text);
        }

        /// <summary>
        ///     MotoCopyCheckCar - Use 'MotoCopyCheckCarExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCopyCheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'RF53OXL'
            Assert.AreEqual(this.MotoCopyCheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '1000'
            Assert.AreEqual(this.MotoCopyCheckCarExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MotoCloseDetails
        /// </summary>
        public void MotoCloseDetails()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(32, 12));
        }

        /// <summary>
        ///     MotoCloseAndOpenPolicyList
        /// </summary>
        public void MotoCloseAndOpenPolicyList()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UICustomertxt1tdsfsWindow.UIItemWindow.UIItemButton;
            WinButton uIDetailButton = this.UICustomertxt1tdsfsWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(31, 15));

            // Click button
            Mouse.Click(uIItemButton, new Point(27, 23));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(52, 11));
        }

        /// <summary>
        ///     MotoCheckPolicyStatus - Use 'MotoCheckPolicyStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCheckPolicyStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow1.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'NEW'
            Assert.AreEqual(this.MotoCheckPolicyStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoCheckChangedPremium - Use 'MotoCheckChangedPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCheckChangedPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '9433.96'
            Assert.AreEqual(this.MotoCheckChangedPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoCheckAWAPpremium - Use 'MotoCheckAWAPpremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCheckAWAPpremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '10000.00'
            Assert.AreEqual(this.MotoCheckAWAPpremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoCancelPolicy_1
        /// </summary>
        public void MotoCancelPolicy_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = this.UIClaimsWindow.UINOWindow.UINOButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(39, 9));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(22, 18));
        }

        /// <summary>
        ///     MotoCancelPolicy - Use 'MotoCancelPolicyParams' to pass parameters into this method.
        /// </summary>
        public void MotoCancelPolicy()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Select 'Cancel Cover' in combo box
            uIItemComboBox.SelectedItem = this.MotoCancelPolicyParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(34, 12));

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(67, 12));
        }

        /// <summary>
        ///     MotoCancelExit
        /// </summary>
        public void MotoCancelExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(59, 16));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(66, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(53, 10));
        }

        /// <summary>
        ///     MotoCalculate
        /// </summary>
        public void MotoCalculate()
        {
            #region Variable Declarations

            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(69, 13));
        }

        /// <summary>
        ///     MotoAWAPCheckTAX - Use 'MotoAWAPCheckTAXExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoAWAPCheckTAX()
        {
            #region Variable Declarations

            WinEdit uILblBalanceEdit = this.UITransactionListWindow.UILblBalanceWindow.UILblBalanceEdit;

            #endregion

            // Verify that the 'Text' property of 'lblBalance' text box equals '600.00'
            Assert.AreEqual(this.MotoAWAPCheckTAXExpectedValues.UILblBalanceEditText, uILblBalanceEdit.Text);
        }

        /// <summary>
        ///     MotoAWAPCheckNEW - Use 'MotoAWAPCheckNEWExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoAWAPCheckNEW()
        {
            #region Variable Declarations

            WinEdit uILblBalanceEdit = this.UITransactionListWindow.UILblBalanceWindow.UILblBalanceEdit;

            #endregion

            // Verify that the 'Text' property of 'lblBalance' text box equals '10,000.00'
            Assert.AreEqual(this.MotoAWAPCheckNEWExpectedValues.UILblBalanceEditText, uILblBalanceEdit.Text);
        }

        /// <summary>
        ///     MotoAmendRiskNew
        /// </summary>
        public void MotoAmendRiskNew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(51, 9));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(60, 14));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(62, 15));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(37, 9));
        }

        /// <summary>
        ///     MotoAmendRisk - Use 'MotoAmendRiskParams' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRisk()
        {
            #region Variable Declarations

            WinButton uIAmendRiskButton = this.UIAUTO2081001Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = this.UIAmendRiskWindow.UIItemWindow.UIItemEdit;
            WinButton uIProposerDetailsButton = this.UIAmendRiskWindow.UIProposerDetailsWindow.UIProposerDetailsButton;
            WinEdit uIItemEdit1 = this.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = this.UIAmendRiskWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;
            WinButton uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click '&Amend Risk...' button
            Mouse.Click(uIAmendRiskButton, new Point(80, 11));

            // Type '1500' in text box
            uIItemEdit.Text = this.MotoAmendRiskParams.UIItemEditText;

            // Click '&Proposer Details...' button
            Mouse.Click(uIProposerDetailsButton, new Point(66, 12));

            // Type 'NewTest' in text box
            uIItemEdit1.Text = this.MotoAmendRiskParams.UIItemEditText1;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(50, 11));

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(58, 6));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(50, 0));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(14, 18));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     Links_1
        /// </summary>
        public void Links_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(40, 5));
        }

        /// <summary>
        ///     HouseRegressApp - Use 'HouseRegressAppParams' to pass parameters into this method.
        /// </summary>
        public void HouseRegressApp()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.UIRegressIETamPolicyWindow.UIItemWindow4.UIItemComboBox;

            #endregion

            // Select 'Household' in combo box
            uIItemComboBox.SelectedItem = this.HouseRegressAppParams.UIItemComboBoxSelectedItem;
        }

        /// <summary>
        ///     HouseProposer - Use 'HouseProposerParams' to pass parameters into this method.
        /// </summary>
        public void HouseProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow11.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow3.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow21.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow31.UIItemComboBox;
            WinEdit uIItemEdit3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinEdit uIItemEdit5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow51.UIItemEdit;
            WinButton uILookupButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type 'test1' in text box
            uIItemEdit.Text = this.HouseProposerParams.UIItemEditText;

            // Type 'test' in text box
            uIItemEdit1.Text = this.HouseProposerParams.UIItemEditText1;

            // Type 'test' in text box
            uIItemEdit2.Text = this.HouseProposerParams.UIItemEditText2;

            // Select 'Advertising Buyer' in combo box
            uIItemComboBox.SelectedItem = this.HouseProposerParams.UIItemComboBoxSelectedItem;

            // Select 'Addressing/Circularising Services' in combo box
            uIItemComboBox1.SelectedItem = this.HouseProposerParams.UIItemComboBoxSelectedItem1;

            // Type '151065' in text box
            uIItemEdit3.Text = this.HouseProposerParams.UIItemEditText3;

            // Click text box
            Mouse.Click(uIItemEdit4, new Point(16, 7));

            // Type 'B338TH' in text box
            uIItemEdit5.Text = this.HouseProposerParams.UIItemEditText4;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(31, 15));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(28, 22));
        }

        /// <summary>
        ///     HomeStartDate - Use 'HomeStartDateParams' to pass parameters into this method.
        /// </summary>
        public void HomeStartDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow13.UIItemEdit;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '10/11/12' in text box
            uIItemEdit.Text = this.HomeStartDateParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeSiteRenewal - Use 'HomeSiteRenewalParams' to pass parameters into this method.
        /// </summary>
        public void HomeSiteRenewal()
        {
            #region Variable Declarations

            HtmlHyperlink uICreateaHouseholdTestHyperlink =
                this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument1.UIDivRenewalsPane.UICreateaHouseholdTestHyperlink;
            HtmlComboBox uIInsurerIDComboBox = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtPolicyNumberEdit;
            HtmlEdit uITxtRenewalDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtRenewalDateEdit;
            HtmlEdit uITxtAutoLapseDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtAutoLapseDateEdit;
            HtmlTextArea uITxtClientXmlEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtClientXmlEdit;
            HtmlInputButton uIGetXMLfromServerButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIGetXMLfromServerButton;
            HtmlInputButton uICreateRecordButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.UIInsurEcomSystemMaintWindow;

            #endregion

            // Click 'Create a Household Test Renewal Invitation' link
            Mouse.Click(uICreateaHouseholdTestHyperlink, new Point(48, 20));

            // Select 'Covea Insurance plc (formerly MMA)' in 'InsurerID' combo box
            uIInsurerIDComboBox.SelectedItem = this.HomeSiteRenewalParams.UIInsurerIDComboBoxSelectedItem;

            // Type '81588888001120' in 'txtPolicyNumber' text box
            uITxtPolicyNumberEdit.Text = this.HomeSiteRenewalParams.UITxtPolicyNumberEditText;

            // Type '14/11/2012' in 'txtRenewalDate' text box
            uITxtRenewalDateEdit.Text = this.HomeSiteRenewalParams.UITxtRenewalDateEditText;

            // Type '14/11/2012' in 'txtAutoLapseDate' text box
            uITxtAutoLapseDateEdit.Text = this.HomeSiteRenewalParams.UITxtAutoLapseDateEditText;

            // Click 'txtClientXml' text box
            Mouse.Click(uITxtClientXmlEdit, new Point(284, 43));

            // Click 'Get XML from Server' button
            Mouse.Click(uIGetXMLfromServerButton, new Point(114, 9));

            // Click 'Create Record' button
            Mouse.Click(uICreateRecordButton, new Point(102, 11));

            // Click 'Ok' button in the browser dialog window
            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        /// <summary>
        ///     HomeSelectPolicy1 - Use 'HomeSelectPolicy1Params' to pass parameters into this method.
        /// </summary>
        public void HomeSelectPolicy1()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIQuotesResultsClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(354, 212));

            // Type '{Home}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeSelectPolicy1Params.UIQuotesResultsClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeSelectPolicy - Use 'HomeSelectPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeSelectPolicy()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIQuotesResultsClient;

            #endregion

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(367, 171));

            // Type '{End}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeSelectPolicyParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeRenewalConfirm
        /// </summary>
        public void HomeRenewalConfirm()
        {
            #region Variable Declarations

            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(33, 10));
        }

        /// <summary>
        ///     HomeRenewalCancelledCheck - Use 'HomeRenewalCancelledCheckExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeRenewalCancelledCheck()
        {
            #region Variable Declarations

            WinText uIMTAsuccessfullyproceText = this.UIMTASuccessfulWindow.UIMTAsuccessfullyproceWindow.UIMTAsuccessfullyproceText;

            #endregion

            // Verify that the 'DisplayText' property of 'MTA successfully processed on a previously renewed...' label contains 'WARNING! - RENEWAL EDI HAS BEEN CANCELLED'
            StringAssert.Contains(uIMTAsuccessfullyproceText.DisplayText, this.HomeRenewalCancelledCheckExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        /// <summary>
        ///     HomeRenewalBeforeFinish - Use 'HomeRenewalBeforeFinishParams' to pass parameters into this method.
        /// </summary>
        public void HomeRenewalBeforeFinish()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 11));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeRenewalBeforeFinishParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(53, 18));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeRenewalBeforeFinishParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(33, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(28, 13));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(35, 11));
        }

        /// <summary>
        ///     HomeRenewalBeforeAccept - Use 'HomeRenewalBeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void HomeRenewalBeforeAccept()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIQuotesResultsClient;
            WinButton uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIOKButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(420, 229));

            // Type '{Home}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeRenewalBeforeAcceptParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Click 'Accept' button
            Mouse.Click(uIAcceptButton, new Point(75, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 16));

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(37, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(48, 14));
        }

        /// <summary>
        ///     HomeRebrokeSelectPolicy - Use 'HomeRebrokeSelectPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeRebrokeSelectPolicy()
        {
            #region Variable Declarations

            WinClient uIHouseholdRebrokeResuClient = this.UIHouseholdRebrokeResuWindow.UIItemWindow.UIHouseholdRebrokeResuClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Household Rebroke Results' client
            Mouse.Click(uIHouseholdRebrokeResuClient, new Point(449, 216));

            // Type '{Home}' in 'Household Rebroke Results' client
            Keyboard.SendKeys(uIHouseholdRebrokeResuClient, this.HomeRebrokeSelectPolicyParams.UIHouseholdRebrokeResuClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     testPrint - Use 'testPrintParams' to pass parameters into this method.
        /// </summary>
        public void testPrint()
        {
            #region Variable Declarations

            WinButton uIPolicySummaryButton = this.UIQuoteResultsWindow.UIPolicySummaryWindow.UIPolicySummaryButton;
            WinComboBox uIFilenameComboBox = this.UISavethefileasWindow.UIDetailsPanePane.UIFilenameComboBox;
            WinButton uISaveButton = this.UISavethefileasWindow.UISaveWindow.UISaveButton;
            WinButton uIYesButton = this.UIConfirmSaveAsWindow.UIConfirmSaveAsPane.UIYesButton;

            #endregion

            // Click 'Policy &Summary' button
            Mouse.Click(uIPolicySummaryButton, new Point(61, 12));

            // Select 'test_print' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.testPrintParams.UIFilenameComboBoxEditableItem;

            // Click '&Save' button
            Mouse.Click(uISaveButton, new Point(59, 8));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(38, 6));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     SelectPolicyQuote - Use 'SelectPolicyQuoteParams' to pass parameters into this method.
        /// </summary>
        public void SelectPolicyQuote()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow.UIQuoteResultsClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(295, 127));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.SelectPolicyQuoteParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     SelectPolicy
        /// </summary>
        public void SelectPolicy()
        {
            #region Variable Declarations

            WinTitleBar uIQuoteResultsTitleBar = this.UIQuoteResultsWindow.UIQuoteResultsTitleBar;
            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIQuoteResultsClient;

            #endregion

            // Wait for 2 seconds for user delay between actions; Click 'Quote Results' title bar
            Playback.Wait(2000);
            Mouse.Click(uIQuoteResultsTitleBar, new Point(736, 10));

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(728, 84));
        }

        /// <summary>
        ///     SelectNextTransaction - Use 'SelectNextTransactionParams' to pass parameters into this method.
        /// </summary>
        public void SelectNextTransaction()
        {
            #region Variable Declarations

            WinList uILvwVListList = this.UITransactionListWindow.UILvwVListWindow.UILvwVListList;

            #endregion

            // Select '381' in 'lvwVList' list box
            uILvwVListList.SelectedItemsAsString = this.SelectNextTransactionParams.UILvwVListListSelectedItemsAsString;

            // Select '381' in 'lvwVList' list box
            uILvwVListList.SelectedItemsAsString = this.SelectNextTransactionParams.UILvwVListListSelectedItemsAsString1;
        }

        /// <summary>
        ///     SelectMotoPolicy - Use 'SelectMotoPolicyParams' to pass parameters into this method.
        /// </summary>
        public void SelectMotoPolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinButton uIOKButton = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            #endregion

            // Type 'MOTO' in text box
            uIItemEdit.Text = this.SelectMotoPolicyParams.UIItemEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(38, 18));
        }

        /// <summary>
        ///     SelectMenu
        /// </summary>
        public void SelectMenu()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3rdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem1.UIItem3rdPartyIntegratMenuItem;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem2.UIItem3rdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;

            #endregion

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(37, 10));

            // Click 'Options' -> 'Links' menu item
            Mouse.Click(uILinksMenuItem, new Point(68, 6));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' menu item
            Mouse.Click(uIItem3rdPartyIntegratMenuItem, new Point(102, 10));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(101, 9));
        }

        /// <summary>
        ///     SelectInsurer
        /// </summary>
        public void SelectInsurer()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow.UIQuoteResultsClient;

            #endregion

            // Wait for 2 seconds for user delay between actions; Click 'Quote Results' client
            Playback.Wait(2000);
            Mouse.Click(uIQuoteResultsClient, new Point(353, 27));
        }

        /// <summary>
        ///     SelectHomeType - Use 'SelectHomeTypeParams' to pass parameters into this method.
        /// </summary>
        public void SelectHomeType()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinButton uIOKButton = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            #endregion

            // Type 'HOME' in text box
            uIItemEdit.Text = this.SelectHomeTypeParams.UIItemEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(40, 15));
        }

        /// <summary>
        ///     SaveWithoutPremium - Use 'SaveWithoutPremiumParams' to pass parameters into this method.
        /// </summary>
        public void SaveWithoutPremium()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinList uIItemList = this.UISelectTaminsurerforiWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton1 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UISelectTaminsurerforiClient.UIOKButton;
            WinButton uIOKButton2 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(55, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(34, 18));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.SaveWithoutPremiumParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(32, 8));

            // Select 'ABD' in list box
            uIItemList.SelectedItemsAsString = this.SaveWithoutPremiumParams.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(33, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(44, 15));
        }

        /// <summary>
        ///     RewiseRecord
        /// </summary>
        public void RewiseRecord()
        {
            #region Variable Declarations

            WinButton uIYesButton = this.UIPolicyWindow.UIYesWindow.UIYesButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(52, 16));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RetrieveResponse
        /// </summary>
        public void RetrieveResponse()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow1.UIOKButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(51, 11));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewConfirmInvite
        /// </summary>
        public void RenewConfirmInvite()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(54, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewalModuleSort
        /// </summary>
        public void RenewalModuleSort()
        {
            #region Variable Declarations

            WinClient uIInsurETAMRenewalsClient = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow12.UIInsurETAMRenewalsClient;

            #endregion

            // The recording for the application under test '\\ICLVDEVTM02\Applied\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\ICLVDEVTM02\Applied\APPS\ieoffice\data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Insur-E TAM Renewals' client
            Mouse.Click(uIInsurETAMRenewalsClient, new Point(24, 8));
        }

        /// <summary>
        ///     RenewalModuleRenew_1 - Use 'RenewalModuleRenew_1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleRenew_1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.RenewalModuleRenew_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(76, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(48, 19));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.RenewalModuleRenew_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(46, 16));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(47, 24));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.RenewalModuleRenew_1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(46, 4));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(44, 8));
        }

        /// <summary>
        ///     RenewalModuleRenew
        /// </summary>
        public void RenewalModuleRenew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIAUTO1871001Window.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(46, 10));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(55, 14));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(44, 16));
        }

        /// <summary>
        ///     RenewalModuleInvite
        /// </summary>
        public void RenewalModuleInvite()
        {
            #region Variable Declarations

            WinButton uIInviteButton = this.UIAUTO1871001Window.UIInviteWindow.UIInviteButton;

            #endregion

            // Click '&Invite' button
            Mouse.Click(uIInviteButton, new Point(75, 8));
        }

        /// <summary>
        ///     RenewalModuleFilterMoto - Use 'RenewalModuleFilterMotoParams' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleFilterMoto()
        {
            #region Variable Declarations

            WinButton uIFilterButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIFilterWindow.UIFilterButton;
            WinEdit uIItemEdit = this.UIFilterRenewalRecordsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIFilterRenewalRecordsWindow.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIFilterRenewalRecordsWindow.UIItemWindow2.UIItemComboBox;
            WinButton uIOKButton = this.UIFilterRenewalRecordsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&Filter...' button
            Mouse.Click(uIFilterButton, new Point(40, 11));

            // Type '12/11/12' in text box
            uIItemEdit.Text = this.RenewalModuleFilterMotoParams.UIItemEditText;

            // Type '12/11/12' in text box
            uIItemEdit1.Text = this.RenewalModuleFilterMotoParams.UIItemEditText1;

            // Select 'Motor' in combo box
            uIItemComboBox.SelectedItem = this.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem;

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(39, 11));
        }

        /// <summary>
        ///     RenewalModuleEDI_1
        /// </summary>
        public void RenewalModuleEDI_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinButton uIExitButton = this.UIPoliciesAutoRenewedAWindow.UIExitWindow.UIExitButton;
            WinButton uIEDIMatchButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIEDIMatchWindow.UIEDIMatchButton;
            WinButton uIOKButton1 = this.UIRenewalSearchWindow.UIOKWindow.UIOKButton;
            WinButton uILogandClearButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UILogandClearWindow.UILogandClearButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 13));

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(33, 11));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click '&EDI Match...' button
            Mouse.Click(uIEDIMatchButton, new Point(59, 10));

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(37, 9));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(46, 21));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Log and Clear' button
            Mouse.Click(uILogandClearButton, new Point(50, 15));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(50, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewalModuleEDI - Use 'RenewalModuleEDIParams' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleEDI()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3rdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem1.UIItem3rdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsModuleMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem2.UIItem3rdPartyIntegratMenuItem.UIRenewalsModuleMenuItem;
            WinEdit uIItemEdit = this.UIIETAMRenewalsWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.UIIETAMRenewalsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(21, 12));

            // Click 'Options' -> 'Links' menu item
            Mouse.Click(uILinksMenuItem, new Point(101, 8));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' menu item
            Mouse.Click(uIItem3rdPartyIntegratMenuItem, new Point(89, 10));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Renewals Module' menu item
            Mouse.Click(uIRenewalsModuleMenuItem, new Point(98, 12));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '1' in text box
            uIItemEdit.Text = this.RenewalModuleEDIParams.UIItemEditText;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(31, 10));
        }

        /// <summary>
        ///     RenewalModuleDisplay - Use 'RenewalModuleDisplayParams' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleDisplay()
        {
            #region Variable Declarations

            WinClient uIInsurETAMRenewalsClient = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow10.UIInsurETAMRenewalsClient;
            WinButton uIDisplayRecordButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIDisplayRecordWindow.UIDisplayRecordButton;

            #endregion

            // Click 'Insur-E TAM Renewals' client
            Mouse.Click(uIInsurETAMRenewalsClient, new Point(10, 10));

            // Type '{End}' in 'Insur-E TAM Renewals' client
            Keyboard.SendKeys(uIInsurETAMRenewalsClient, this.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys, ModifierKeys.None);

            // Click 'Display Record...' button
            Mouse.Click(uIDisplayRecordButton, new Point(67, 11));
        }

        /// <summary>
        ///     RenewalModuleConfirm
        /// </summary>
        public void RenewalModuleConfirm()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(45, 13));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewalModuleClose
        /// </summary>
        public void RenewalModuleClose()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(44, 19));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(44, 14));
        }

        /// <summary>
        ///     RenewalLoaderRun - Use 'RenewalLoaderRunParams' to pass parameters into this method.
        /// </summary>
        public void RenewalLoaderRun()
        {
            #region Variable Declarations

            WinTitleBar uIRenewalLoaderTitleBar = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinEdit uIItemEdit = this.UIRenewalLoaderWindow.UIItem12122012Window.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIRenewalLoaderWindow.UIItem13122012Window.UIItemEdit;
            WinButton uIRunButton = this.UIRenewalLoaderWindow.UIRenewalLoaderClient.UIRunButton;

            #endregion

            // Click 'Renewal Loader' title bar
            Mouse.Click(uIRenewalLoaderTitleBar, new Point(103, 8));

            // Type '12/12/2012' in text box
            uIItemEdit.Text = this.RenewalLoaderRunParams.UIItemEditText;

            // Type '22/12/2012' in text box
            uIItemEdit1.Text = this.RenewalLoaderRunParams.UIItemEditText1;

            // Click 'Run' button
            Mouse.Click(uIRunButton, new Point(42, 15));
        }

        /// <summary>
        ///     RenewalLoaderOpen
        /// </summary>
        public void RenewalLoaderOpen()
        {
            #region Variable Declarations

            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3rdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem1.UIItem3rdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsLoaderMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UIRenewalsLoaderMenuItem;

            #endregion

            // Click button
            Mouse.Click(uIItemButton, new Point(25, 19));

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(28, 11));

            // Click 'Options' -> 'Links' menu item
            Mouse.Click(uILinksMenuItem, new Point(79, 10));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' menu item
            Mouse.Click(uIItem3rdPartyIntegratMenuItem, new Point(100, 16));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Renewals Loader' menu item
            Mouse.Click(uIRenewalsLoaderMenuItem, new Point(111, 11));
        }

        /// <summary>
        ///     RenewalLoaderClose
        /// </summary>
        public void RenewalLoaderClose()
        {
            #region Variable Declarations

            WinTitleBar uIRenewalLoaderTitleBar = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinButton uICloseButton = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar.UICloseButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\RLoader.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Renewal Loader' title bar
            Mouse.Click(uIRenewalLoaderTitleBar, new Point(89, 11));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(18, 9));
        }

        /// <summary>
        ///     RenewalCheckStatus - Use 'RenewalCheckStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        public void RenewalCheckStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow1.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'REN'
            Assert.AreEqual(this.RenewalCheckStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     RenewalCheckInvited - Use 'RenewalCheckInvitedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void RenewalCheckInvited()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIAUTO1871001Window.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'Invited'
            Assert.AreEqual(this.RenewalCheckInvitedExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     RenewalAfterMTA1 - Use 'RenewalAfterMTA1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalAfterMTA1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uIAfterButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;
            WinButton uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = this.UIMidTermAdjustmentsWindow.UIOKWindow1.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(42, 14));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&After' button
            Mouse.Click(uIAfterButton, new Point(37, 8));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(55, 10));

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.RenewalAfterMTA1Params.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(39, 17));

            // Type '888888' in text box
            uIItemEdit.Text = this.RenewalAfterMTA1Params.UIItemEditText;

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(71, 13));
        }

        /// <summary>
        ///     RegressAppDate - Use 'RegressAppDateParams' to pass parameters into this method.
        /// </summary>
        public void RegressAppDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIRegressIETamPolicyWindow.UIItemWindow3.UIItemEdit;

            #endregion

            // Type '10/11/2011' in text box
            uIItemEdit.Text = this.RegressAppDateParams.UIItemEditText;
        }

        /// <summary>
        ///     RegistryHighway - Use 'RegistryHighwayParams' to pass parameters into this method.
        /// </summary>
        public void RegistryHighway()
        {
            #region Variable Declarations

            WinComboBox uIOpenComboBox = this.UIRunWindow.UIItemWindow1.UIOpenComboBox;
            WinButton uIOKButton = this.UIRunWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.UIRegistryEditorWindow.UIRegistryEditorPane.UIYesButton;
            WinButton uIOKButton1 = this.UIRegistryEditorWindow.UIRegistryEditorPane.UIOKButton;

            #endregion

            // Press keyboard shortcut keys 'Windows + R'
            Keyboard.SendKeys(this.RegistryHighwayParams.SendKeys, ModifierKeys.Windows);

            // Select 'c:\TestProject7\ourhighway.reg' in 'Open:' combo box
            uIOpenComboBox.EditableItem = this.RegistryHighwayParams.UIOpenComboBoxEditableItem;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 16));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(41, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(16, 10));
        }

        /// <summary>
        ///     RecordedMethod6
        /// </summary>
        public void RecordedMethod6()
        {
            #region Variable Declarations

            WinListItem uITestProject7ListItem = this.UIProgramManagerWindow.UIDesktopList.UITestProject7ListItem;

            #endregion

            // Click 'TestProject7' list item
            Mouse.Click(uITestProject7ListItem, new Point(28, 16));
        }

        /// <summary>
        ///     RecordedMethod5 - Use 'RecordedMethod5Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod5()
        {
            #region Variable Declarations

            WinButton uIPolicySummaryButton = this.UIQuoteResultsWindow.UIPolicySummaryWindow.UIPolicySummaryButton;
            WinComboBox uIFilenameComboBox = this.UISavethefileasWindow.UIDetailsPanePane.UIFilenameComboBox;
            WinButton uISaveButton = this.UISavethefileasWindow.UISaveWindow.UISaveButton;

            #endregion

            // Click 'Policy &Summary' button
            Mouse.Click(uIPolicySummaryButton, new Point(46, 14));

            // Last mouse action was not recorded.

            // Select '⁬test_print' in 'File name:' combo box
            uIFilenameComboBox.EditableItem = this.RecordedMethod5Params.UIFilenameComboBoxEditableItem;

            // Click '&Save' button
            Mouse.Click(uISaveButton, new Point(38, 12));
        }

        /// <summary>
        ///     RecordedMethod4_1
        /// </summary>
        public void RecordedMethod4_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(23, 9));
        }

        /// <summary>
        ///     RecordedMethod4
        /// </summary>
        public void RecordedMethod4()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(40, 13));
        }

        /// <summary>
        ///     RecordedMethod3 - Use 'RecordedMethod3Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod3()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyrtyertWindow.UIBillingScreenMOTOTESWindow.UIItemWindow.UIItemEdit;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '8711.32' in text box
            uIItemEdit.Text = this.RecordedMethod3Params.UIItemEditText;
        }

        /// <summary>
        ///     RecordedMethod2 - Use 'RecordedMethod2Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow.UIQuoteResultsClient;
            WinRadioButton uIComprehensiveRadioButton = this.UIQuoteResultsWindow.UIComprehensiveWindow.UIComprehensiveRadioButton;
            WinButton uIPrintQuoteButton = this.UIQuoteResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;
            WinButton uIOKButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(188, 25));

            // Type '{Space}' in 'Comprehensive' radio button
            Keyboard.SendKeys(uIComprehensiveRadioButton, this.RecordedMethod2Params.UIComprehensiveRadioButtonSendKeys, ModifierKeys.None);

            // Click '&Print Quote...' button
            Mouse.Click(uIPrintQuoteButton, new Point(43, 11));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(97, 10));
        }

        /// <summary>
        ///     RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyrtyertWindow.UIBillingScreenMOTOTESWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click text box
            Mouse.Click(uIItemEdit, new Point(45, 4));
        }

        /// <summary>
        ///     RebrokeSelectAlternative
        /// </summary>
        public void RebrokeSelectAlternative()
        {
            #region Variable Declarations

            WinButton uISelectAlternativeButton = this.UIRebrokeResultsScreenWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Select Alternative' button
            Mouse.Click(uISelectAlternativeButton, new Point(56, 13));
        }

        /// <summary>
        ///     RebrokeAlternativeRenew_1 - Use 'RebrokeAlternativeRenew_1Params' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeRenew_1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.RebrokeAlternativeRenew_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(63, 21));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(49, 8));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(62, 14));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.RebrokeAlternativeRenew_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(44, 7));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(54, 7));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.RebrokeAlternativeRenew_1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(59, 13));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(48, 4));
        }

        /// <summary>
        ///     RebrokeAlternativeRenew - Use 'RebrokeAlternativeRenewParams' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeRenew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIAUTO2311001Window.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinButton uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIRenewalsNewBusinessAClient = this.UIRenewalsNewBusinessAWindow1.UIItemWindow.UIRenewalsNewBusinessAClient;
            WinButton uIAcceptButton = this.UIRenewalsNewBusinessAWindow1.UIAcceptWindow.UIAcceptButton;
            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click '&Renew Policy...' button
            Mouse.Click(uIRenewPolicyButton, new Point(48, 13));

            // Select 'Alternative' radio button
            uIAlternativeRadioButton.Selected = this.RebrokeAlternativeRenewParams.UIAlternativeRadioButtonSelected;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(52, 20));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(36, 11));

            // Click 'Renewals: New Business Accept' client
            Mouse.Click(uIRenewalsNewBusinessAClient, new Point(433, 51));

            // Click '&Accept' button
            Mouse.Click(uIAcceptButton, new Point(45, 17));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(51, 14));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RebrokeAlternativeFinish_1 - Use 'RebrokeAlternativeFinish_1Params' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeFinish_1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.RebrokeAlternativeFinish_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(75, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(50, 6));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(58, 13));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.RebrokeAlternativeFinish_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(46, 14));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(49, 7));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.RebrokeAlternativeFinish_1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(55, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(41, 10));
        }

        /// <summary>
        ///     RebrokeAlternativeFinish - Use 'RebrokeAlternativeFinishParams' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeFinish()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.UIAUTO2211001Window.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinButton uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIItemClient = this.UIRenewalsNewBusinessAWindow.UIItemWindow.UIItemClient;
            WinButton uIAcceptButton = this.UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(79, 13));

            // Select 'Alternative' radio button
            uIAlternativeRadioButton.Selected = this.RebrokeAlternativeFinishParams.UIAlternativeRadioButtonSelected;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(30, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(27, 13));

            // Click client
            Mouse.Click(uIItemClient, new Point(398, 91));

            // Type '{Home}' in client
            Keyboard.SendKeys(uIItemClient, this.RebrokeAlternativeFinishParams.UIItemClientSendKeys, ModifierKeys.None);

            // Click '&Accept' button
            Mouse.Click(uIAcceptButton, new Point(51, 9));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(36, 9));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(71, 16));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(72, 10));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(74, 15));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     QuoteResults_1
        /// </summary>
        public void QuoteResults_1()
        {
            #region Variable Declarations

            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;

            #endregion

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(28, 10));
        }

        /// <summary>
        ///     QuoteResults - Use 'QuoteResultsParams' to pass parameters into this method.
        /// </summary>
        public void QuoteResults()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = this.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinButton uIOKButton1 = this.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit1 = this.UIVehicleLookupWindow.UIItemWindow.UIItemEdit;
            WinButton uIFilterButton = this.UIVehicleLookupWindow.UIFilterWindow.UIFilterButton;
            WinButton uIOKButton2 = this.UIVehicleLookupWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(44, 12));

            // Select 'Account Executive' in combo box
            uIItemComboBox.SelectedItem = this.QuoteResultsParams.UIItemComboBoxSelectedItem;

            // Select 'Acupuncture' in combo box
            uIItemComboBox1.SelectedItem = this.QuoteResultsParams.UIItemComboBoxSelectedItem1;

            // Type '151101' in text box
            uIItemEdit.Text = this.QuoteResultsParams.UIItemEditText;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(38, 4));

            // Type 'RF53OXL' in text box
            uIItemEdit1.Text = this.QuoteResultsParams.UIItemEditText1;

            // Click '&Filter' button
            Mouse.Click(uIFilterButton, new Point(59, 14));

            // Click '&OK' button
            Mouse.Click(uIOKButton2, new Point(33, 5));

            // Type '1000' in text box
            uIItemEdit2.Text = this.QuoteResultsParams.UIItemEditText2;

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(25, 13));
        }

        /// <summary>
        ///     PublicCreditCheckOk
        /// </summary>
        public void PublicCreditCheckOk()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIErrorWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(49, 10));
        }

        /// <summary>
        ///     PrintQuote
        /// </summary>
        public void PrintQuote()
        {
            #region Variable Declarations

            WinButton uIPrintQuoteButton = this.UIQuoteResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

            #endregion

            // Wait for 2 seconds for user delay between actions; Click '&Print Quote...' button
            Playback.Wait(2000);
            Mouse.Click(uIPrintQuoteButton, new Point(49, 10));
        }

        /// <summary>
        ///     PostcodeLookup - Use 'PostcodeLookupExpectedValues' to pass parameters into this method.
        /// </summary>
        public void PostcodeLookup()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIProposerDetailsWindow.UIItemWindow5.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '533 Yardley Green Road'
            Assert.AreEqual(this.PostcodeLookupExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals 'BIRMINGHAM'
            Assert.AreEqual(this.PostcodeLookupExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     Options
        /// </summary>
        public void Options()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UICustomertxt1tdsfsWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;

            #endregion

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(29, 11));
        }

        /// <summary>
        ///     OpenTransactions
        /// </summary>
        public void OpenTransactions()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow1.UIItemButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UIBillingScreenHOMEWindow1.UIDetailWindow.UIDetailButton;
            WinButton uICancelButton1 = this.UIUpdateGeneralTransacWindow.UICancelWindow.UICancelButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(30, 10));

            // Click button
            Mouse.Click(uIItemButton, new Point(8, 13));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(42, 17));

            // Click 'Cance&l' button
            Mouse.Click(uICancelButton1, new Point(37, 11));
        }

        /// <summary>
        ///     OpenSiteForRenewal - Use 'OpenSiteForRenewalParams' to pass parameters into this method.
        /// </summary>
        public void OpenSiteForRenewal()
        {
            #region Variable Declarations

            WinEdit uIUsernameEdit = this.UIWindowsSecurityWindow.UIItemListItem.UIUsernameEdit;
            WinWindow uIItemWindow = this.UIWindowsSecurityWindow.UIItemListItem.UIItemWindow;
            WinEdit uIPasswordEdit = this.UIWindowsSecurityWindow.UIItemListItem.UIPasswordEdit;
            WinButton uIOKButton = this.UIWindowsSecurityWindow.UIWindowsSecurityPane.UIOKButton;
            HtmlHyperlink uIRenewalsMaintenanceHyperlink = this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIRenewalsMaintenanceHyperlink;

            #endregion

            // Go to web page 'https://www.insur-econnect.com/sysmaint/default.asp?mode=1' using new browser instance
            this.UIBlankPageMicrosoftInWindow.LaunchUrl(new Uri(this.OpenSiteForRenewalParams.UIBlankPageMicrosoftInWindowUrl));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'User name' text box
            Mouse.Click(uIUsernameEdit, new Point(92, 7));

            // Type 'Bus sys' in window
            Keyboard.SendKeys(uIItemWindow, this.OpenSiteForRenewalParams.UIItemWindowSendKeys, ModifierKeys.None);

            // Click 'Password' text box
            Mouse.Click(uIPasswordEdit, new Point(90, 0));

            // Type '********' in 'Password' text box
            Keyboard.SendKeys(uIPasswordEdit, this.OpenSiteForRenewalParams.UIPasswordEditSendKeys, true);

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(43, 19));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Renewals Maintenance' link
            Mouse.Click(uIRenewalsMaintenanceHyperlink, new Point(40, 13));
        }

        /// <summary>
        ///     OpenPolicyAttachments
        /// </summary>
        public void OpenPolicyAttachments()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;
            WinClient uIItemClient = this.UIPolicyautotestWindow.UIPolicyListWindow.UIItemWindow.UIItemClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(35, 12));

            // Double-Click client
            Mouse.DoubleClick(uIItemClient, new Point(16, 10));
        }

        /// <summary>
        ///     MTAMessageBeforeCurrent - Use 'MTAMessageBeforeCurrentExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MTAMessageBeforeCurrent()
        {
            #region Variable Declarations

            WinText uIDateBeforeCurrentMTAText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            #endregion

            // Verify that the 'DisplayText' property of 'Date Before Current MTA Effective Date - Please en...' label equals 'Date Before Current MTA Effective Date - Please enter Adjustment Date.'
            Assert.AreEqual(this.MTAMessageBeforeCurrentExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText);
        }

        /// <summary>
        ///     MTAEffectiveDatesCancel
        /// </summary>
        public void MTAEffectiveDatesCancel()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(28, 12));
        }

        /// <summary>
        ///     MTADate - Use 'MTADateParams' to pass parameters into this method.
        /// </summary>
        public void MTADate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            // Type '20/11/12' in text box
            uIItemEdit.Text = this.MTADateParams.UIItemEditText;

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(39, 10));
        }

        /// <summary>
        ///     MTACloseMessageBefore
        /// </summary>
        public void MTACloseMessageBefore()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(52, 12));
        }

        /// <summary>
        ///     MTACloseMessageAfter
        /// </summary>
        public void MTACloseMessageAfter()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(59, 13));
        }

        /// <summary>
        ///     MTACancel
        /// </summary>
        public void MTACancel()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;
            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(26, 13));

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(65, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(46, 9));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(50, 11));
        }

        /// <summary>
        ///     MotoSelectHighwayPolicy - Use 'MotoSelectHighwayPolicyParams' to pass parameters into this method.
        /// </summary>
        public void MotoSelectHighwayPolicy()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow2.UIQuoteResultsClient;

            #endregion

            // The recording for the application under test '\\ICLVDEVAP01\J-Drive\APPS\IEOffice\DATA\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(405, 217));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoSelectHighwayPolicyParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // The recording for the application under test '\\ICLVDEVAP01\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.
        }

        /// <summary>
        ///     MotoSearchCar - Use 'MotoSearchCarParams' to pass parameters into this method.
        /// </summary>
        public void MotoSearchCar()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = this.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinButton uIOKButton1 = this.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox2 = this.UIVehicleLookupWindow.UIItemWindow1.UIItemComboBox;
            WinComboBox uIItemComboBox3 = this.UIVehicleLookupWindow.UIItemWindow11.UIItemComboBox;
            WinButton uIFilterButton = this.UIVehicleLookupWindow.UIFilterWindow1.UIFilterButton;
            WinButton uIOKButton2 = this.UIVehicleLookupWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(40, 9));

            // Select 'Account Executive' in combo box
            uIItemComboBox.SelectedItem = this.MotoSearchCarParams.UIItemComboBoxSelectedItem;

            // Select 'Aerial Manufacturer' in combo box
            uIItemComboBox1.SelectedItem = this.MotoSearchCarParams.UIItemComboBoxSelectedItem1;

            // Type '151208' in text box
            uIItemEdit.Text = this.MotoSearchCarParams.UIItemEditText;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(45, 18));

            // Select 'FORD' in combo box
            uIItemComboBox2.EditableItem = this.MotoSearchCarParams.UIItemComboBoxEditableItem;

            // Select 'KA' in combo box
            uIItemComboBox3.EditableItem = this.MotoSearchCarParams.UIItemComboBoxEditableItem1;

            // Click '&Filter' button
            Mouse.Click(uIFilterButton, new Point(29, 9));

            // Click '&OK' button
            Mouse.Click(uIOKButton2, new Point(24, 10));

            // Type '123434' in text box
            uIItemEdit1.Text = this.MotoSearchCarParams.UIItemEditText1;

            // Type '1000' in text box
            uIItemEdit2.Text = this.MotoSearchCarParams.UIItemEditText2;
        }

        /// <summary>
        ///     MotoRenewalCheckRecord - Use 'MotoRenewalCheckRecordExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoRenewalCheckRecord()
        {
            #region Variable Declarations

            WinWindow uIAUTO1871001Window = this.UIAUTO1871001Window;

            #endregion

            // Verify that the 'Name' property of 'AUTO187-1001' window contains 'AUTO187'
            StringAssert.Contains(uIAUTO1871001Window.Name, this.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName);
        }

        /// <summary>
        ///     MotoRegressAppFinish
        /// </summary>
        public void MotoRegressAppFinish()
        {
            #region Variable Declarations

            WinButton uIRegressButton = this.UIRegressIETamPolicyWindow.UIRegressWindow.UIRegressButton;

            #endregion

            // Click 'Regress' button
            Mouse.Click(uIRegressButton, new Point(47, 22));
        }

        /// <summary>
        ///     MotoRegressApp - Use 'MotoRegressAppParams' to pass parameters into this method.
        /// </summary>
        public void MotoRegressApp()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIRegressIETamPolicyWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIRegressIETamPolicyWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Launch 'C:\TestProject7\Regress_IETam_Policy.exe'
            ApplicationUnderTest regress_IETam_PolicyApplication = ApplicationUnderTest.Launch(this.MotoRegressAppParams.ExePath, this.MotoRegressAppParams.AlternateExePath);

            // Type 'AUTO182' in text box
            uIItemEdit.Text = this.MotoRegressAppParams.UIItemEditText;

            // Type '-1001' in text box
            uIItemEdit1.Text = this.MotoRegressAppParams.UIItemEditText1;
        }

        /// <summary>
        ///     MotoRebrokeSelectScheme - Use 'MotoRebrokeSelectSchemeParams' to pass parameters into this method.
        /// </summary>
        public void MotoRebrokeSelectScheme()
        {
            #region Variable Declarations

            WinClient uIItemClient = this.UIRebrokeResultsScreenWindow.UIItemWindow1.UIItemClient;
            WinClient uIItemClient1 = this.UIRebrokeResultsScreenWindow.UIItemWindow2.UIItemClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click client
            Mouse.Click(uIItemClient, new Point(271, 102));

            // Type '{Home}' in client
            Keyboard.SendKeys(uIItemClient1, this.MotoRebrokeSelectSchemeParams.UIItemClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     MotoRebrokeCurrent
        /// </summary>
        public void MotoRebrokeCurrent()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIRebrokeResultsScreenWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(50, 10));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(43, 11));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     MotoRebroke
        /// </summary>
        public void MotoRebroke()
        {
            #region Variable Declarations

            WinButton uIRebrokeButton = this.UIAUTO2081001Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Re&broke...' button
            Mouse.Click(uIRebrokeButton, new Point(86, 12));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(48, 17));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(48, 11));
        }

        /// <summary>
        ///     MotoPostcodeLookup - Use 'MotoPostcodeLookupParams' to pass parameters into this method.
        /// </summary>
        public void MotoPostcodeLookup()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = this.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = this.UISearchResultForBN16BWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(41, 13));

            // Type 'test' in text box
            uIItemEdit.Text = this.MotoPostcodeLookupParams.UIItemEditText;

            // Type 'test' in text box
            uIItemEdit1.Text = this.MotoPostcodeLookupParams.UIItemEditText1;

            // Type '160486' in text box
            uIItemEdit2.Text = this.MotoPostcodeLookupParams.UIItemEditText2;

            // Type 'BN16BN' in text box
            uIItemEdit3.Text = this.MotoPostcodeLookupParams.UIItemEditText3;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(9, 12));

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(37, 9));
        }

        /// <summary>
        ///     MotoPolicyPerson - Use 'MotoPolicyPersonParams' to pass parameters into this method.
        /// </summary>
        public void MotoPolicyPerson()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = this.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(52, 17));

            // Type 'Test' in text box
            uIItemEdit.Text = this.MotoPolicyPersonParams.UIItemEditText;

            // Type '{Tab}' in text box
            Keyboard.SendKeys(uIItemEdit, this.MotoPolicyPersonParams.UIItemEditSendKeys, ModifierKeys.None);

            // Type 'test' in text box
            uIItemEdit1.Text = this.MotoPolicyPersonParams.UIItemEditText1;

            // Type '160485' in text box
            uIItemEdit2.Text = this.MotoPolicyPersonParams.UIItemEditText2;

            // Type 'B338TH' in text box
            uIItemEdit3.Text = this.MotoPolicyPersonParams.UIItemEditText3;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(34, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(38, 12));
        }

        /// <summary>
        ///     MotoMTAOpenQuote
        /// </summary>
        public void MotoMTAOpenQuote()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(33, 12));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(116, 15));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(29, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.
        }

        /// <summary>
        ///     MotoMTANoSave - Use 'MotoMTANoSaveParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTANoSave()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton1 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select 'Change of Driver' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTANoSaveParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(42, 16));

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(70, 10));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 13));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(39, 15));
        }

        /// <summary>
        ///     MotoMTAMessageCancelled - Use 'MotoMTAMessageCancelledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageCancelled()
        {
            #region Variable Declarations

            WinText uIMTAsuccessfullyproceText = this.UIMTASuccessfulWindow.UIMTAsuccessfullyproceWindow.UIMTAsuccessfullyproceText;

            #endregion

            // Verify that the 'DisplayText' property of 'MTA successfully processed on a previously renewed...' label contains 'RENEWAL EDI HAS BEEN CANCELLED'
            StringAssert.Contains(uIMTAsuccessfullyproceText.DisplayText, this.MotoMTAMessageCancelledExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAMessageAfterDate - Use 'MotoMTAMessageAfterDateExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageAfterDate()
        {
            #region Variable Declarations

            WinText uIAdjustmentdatetimecaText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIAdjustmentdatetimecaText;

            #endregion

            // Verify that the 'DisplayText' property of 'Adjustment date/time cannot be after the policy ef...' label contains 'Adjustment date/time cannot be after the policy effective end date/time'
            StringAssert.Contains(uIAdjustmentdatetimecaText.DisplayText, this.MotoMTAMessageAfterDateExpectedValues.UIAdjustmentdatetimecaTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy_1
        /// </summary>
        public void MotoMTAConfirmPolicy_1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(37, 25));
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy - Use 'MotoMTAConfirmPolicyParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTAConfirmPolicy()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow2.UIQuoteResultsClient;
            WinClient uIQuoteResultsClient1 = this.UIQuoteResultsWindow.UIItemWindow3.UIQuoteResultsClient;
            WinButton uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(362, 176));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient1, this.MotoMTAConfirmPolicyParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(54, 8));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(40, 12));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(50, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(32, 8));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoMTAConfirmPolicyParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(42, 12));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoMTAConfirmPolicyParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(24, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(37, 10));
        }

        /// <summary>
        ///     MotoMTAConfirmDate
        /// </summary>
        public void MotoMTAConfirmDate()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(21, 17));
        }

        /// <summary>
        ///     MotoMTACloseMessage
        /// </summary>
        public void MotoMTACloseMessage()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(56, 8));
        }

        /// <summary>
        ///     MotoMTACheckNewValue - Use 'MotoMTACheckNewValueExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTACheckNewValue()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '2000'
            Assert.AreEqual(this.MotoMTACheckNewValueExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoMTACheckCar - Use 'MotoMTACheckCarExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTACheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'RF53OXL'
            Assert.AreEqual(this.MotoMTACheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '2000'
            Assert.AreEqual(this.MotoMTACheckCarExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MotoMTABeforeFinish - Use 'MotoMTABeforeFinishParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeFinish()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(28, 8));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoMTABeforeFinishParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(69, 14));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoMTABeforeFinishParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(46, 21));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(39, 8));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(24, 10));
        }

        /// <summary>
        ///     MotoMTABeforeAccept - Use 'MotoMTABeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeAccept()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow2.UIQuoteResultsClient;
            WinButton uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(401, 181));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoMTABeforeAcceptParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(56, 12));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 11));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(31, 21));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(38, 19));
        }

        /// <summary>
        ///     MotoMTABefore2 - Use 'MotoMTABefore2Params' to pass parameters into this method.
        /// </summary>
        public void MotoMTABefore2()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(44, 11));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(57, 12));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(53, 9));

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTABefore2Params.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(36, 16));

            // Type '23423' in text box
            uIItemEdit.Text = this.MotoMTABefore2Params.UIItemEditText;

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(59, 11));
        }

        /// <summary>
        ///     MotoMTABefore - Use 'MotoMTABeforeParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABefore()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uIBeforeButton = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;
            WinButton uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow1.UIItemComboBox;
            WinButton uIOKButton1 = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(35, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Before' button
            Mouse.Click(uIBeforeButton, new Point(19, 16));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(44, 11));

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTABeforeParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(44, 21));

            // Type '77777' in text box
            uIItemEdit.Text = this.MotoMTABeforeParams.UIItemEditText;

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(61, 15));
        }

        /// <summary>
        ///     MotoMTAAccept - Use 'MotoMTAAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTAAccept()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTAAcceptParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(28, 12));

            // Type '2000' in text box
            uIItemEdit.Text = this.MotoMTAAcceptParams.UIItemEditText;

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(68, 4));
        }

        /// <summary>
        ///     MotoMTA
        /// </summary>
        public void MotoMTA()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;

            #endregion

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(37, 10));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(80, 15));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(41, 10));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(67, 11));
        }

        /// <summary>
        ///     MotoInceptionDate - Use 'MotoInceptionDateParams' to pass parameters into this method.
        /// </summary>
        public void MotoInceptionDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow13.UIItemEdit;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '13/11/12' in text box
            uIItemEdit.Text = this.MotoInceptionDateParams.UIItemEditText;
        }

        /// <summary>
        ///     MotoFinishMTA - Use 'MotoFinishMTAParams' to pass parameters into this method.
        /// </summary>
        public void MotoFinishMTA()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow2.UIQuoteResultsClient;
            WinButton uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinClient uIPointOfSaleClient = this.UIPointOfSaleWindow.UIPointOfSaleClient;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(371, 177));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoFinishMTAParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(51, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(57, 13));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(38, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(59, 17));

            // Click 'Point Of Sale' client
            Mouse.Click(uIPointOfSaleClient, new Point(477, 239));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoFinishMTAParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(54, 19));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoFinishMTAParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(43, 6));

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(48, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(38, 12));
        }

        /// <summary>
        ///     MotoExitMTA
        /// </summary>
        public void MotoExitMTA()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(51, 10));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(13, 9));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(55, 12));
        }

        /// <summary>
        ///     MotoCopyRiskProposerOk
        /// </summary>
        public void MotoCopyRiskProposerOk()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.UIProposerDetailsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(44, 7));
        }

        /// <summary>
        ///     MotoCopyRiskExit
        /// </summary>
        public void MotoCopyRiskExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uINOButton = this.UIInsurEtamWindow1.UINOWindow.UINOButton;
            WinButton uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(66, 10));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(47, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(34, 11));
        }

        /// <summary>
        ///     MotoCopyFinishedRisk
        /// </summary>
        public void MotoCopyFinishedRisk()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = this.UIWhichpolicywouldyoulWindow.UIItemWindow.UIWhichpolicywouldyoulClient.UIOKButton;
            WinButton uIOKButton1 = this.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(29, 12));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Copy Risk' menu item
            Mouse.Click(uICopyRiskMenuItem, new Point(79, 13));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(57, 15));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(31, 15));
        }
    }
}