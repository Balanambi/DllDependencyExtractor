# DllDependencyExtractor
Create a new .NET Console Project:

dotnet new console -n DllDependencyExtractor
cd DllDependencyExtractor

Add necessary NuGet packages:
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet add package System.Reflection.MetadataLoadContext

Run the project:
dotnet run


# STRATEGIC ARCHITECTURE EVALUATION
## Enterprise CIB Revenue Management & Billing Platforms
### Deep Technical and Financial Comparison: Oracle ORMB vs. InvestCloud AdvantageFee

**Prepared For:** Senior Managing Directors & Executive Board  
**Domain Scope:** Custody, Fund Accounting & Collateral Systems  
**Target Architecture:** Tier-1 Institutional Framework (Bank of America Scale)  
**Date:** July 2026  
**Classification:** CONFIDENTIAL - CIB ENTERPRISE ARCHITECTURE BOARD PRE-READ  

---

## Executive Core Architecture Summary
Operational paradigms designed for unique structural requirements:

*   **Oracle ORMB Paradigm:** Designed as a heavy, multi-threaded sub-ledger transactional grid engine. It is optimized to ingest raw, unaggregated, high-volume event data straight into low-level database structural staging architectures.
    *   *Core Focus:* High-velocity transactional scale, global statutory taxation compliance, multi-currency processing loops, and dynamic operational banking balance offsets.
*   **InvestCloud AdvantageFee Paradigm:** Engineered as an event-driven, API-first balance-and-valuation framework. It leverages unified orchestration loops to apply rule-based configurations onto pre-aggregated asset snapshots.
    *   *Core Focus:* Asset-servicing rules, multi-tier legal structures, advanced performance hurdles, automated operational exceptions, and responsive management dashboards.

---

## 1. Product Overviews

*   **InvestCloud AdvantageFee** is a highly targeted, boutique solution tailored specifically for wealth management, asset management, and asset servicing institutions. It emphasizes modern user interfaces, visual dashboards, and flexible fee modeling for high-net-worth and institutional clients. [cite: 9]
*   **Oracle Revenue Management and Billing (ORMB)** is an enterprise-grade, highly robust revenue management engine built to handle massive volumes of transactions across banking, financial services, and insurance industries. It is designed to act as a centralized, high-throughput billing core for Tier-1 corporate and investment banks. [cite: 9]

---

## 2. Technical Architecture & Platform Core

### 2.1 Oracle ORMB
Oracle ORMB is built upon the Oracle Utilities Application Framework (OUAF). It operates as a high-performance sub-ledger engine designed to fit cleanly inside an Oracle enterprise environment (Oracle Database, WebLogic Application Server, Oracle Cloud Infrastructure). [cite: 11]

#### Architecture Data Flow:
`[Upstream CIB Systems] -> [Kafka / MQ Infrastructure] -> [Staging Tables: CI_TXN_IN] -> [OUAF Parallel Batch Processing Engine] -> [Oracle Database Partitioned Ledger Storage] -> [Output: SWIFT ISO 20022 / ERP Feeds]` [cite: 11]

The infrastructure centers around high-volume operational ingestion tables, primarily `CI_TXN_IN`. Data ingestion splits into separate threads running across parallel processes, allowing the system to scrub, validate, and structure trade and transaction events efficiently. [cite: 11]

#### Production Sub-Ledger Layout (Banking Control Central & Transaction Monitors)
```text
ORMB SYSTEM INTERFACE MODULE: BANKING CONTROL CENTRAL [CLIENT HIERARCHY]
| [MENU] File Edit View Batch-Run Audit-Logs Tools Help USER: CIB_OPERATIONS_SR |
INST_PARENT_ID: BOA_GLOBAL_CIB_001 | SEARCH PIPELINE: [ CI_TXN_IN / MONITORS ] |
SUB_FUND_01: INTL_EQUITY_POOL_A | Active Batch Threads: 64/64 [RUNNING] |
SUB_FUND_02: GLOBAL_FIXED_INCOME_B | Raw Ingested Count: 842,910,211 Txns |
CUST_ACCT_03: COLLATERAL_SETTLEMENT_CORE | Processing Velocity: 48,500 Txns / Sec |
BILL SEGMENTS MONITOR [PERIOD: 2026-M06] |
[Line 01] Custody Clearings: 12,450,000 Units @ $0.025 / Tier 1 | Subtotal: $311,250.00 |
[Line 02] Safekeeping Balance: $45,890,200,000 @ 0.00015 Bps | Subtotal: $6,883.53 |
[Line 03] Collateral Variance: 45,100 Margin Cls @ $12.50 / Call | Subtotal: $563,750.00 |
[ECR OFFSET] DDA Balance Pool: $2,500,000,000 @ 1.85% ECR Rate | Offset: -$3,854.16 |
STATUS: APPROVED [POSTED TO LEAF SEGMENT: CI_BILL_SEC] | TOTAL DUES: $878,029.37 |
```
*Note: The ORMB interface functions as an analytical sub-ledger framework. Raw transaction arrays are compiled directly through low-level engine views (`CI_TXN_IN`) where volume-tiered parameters match against institutional parent umbrellas.* [cite: 10]

### 2.2 InvestCloud AdvantageFee
InvestCloud AdvantageFee leverages the InvestCloud Wealth Data Platform (WDP). It is designed as a cloud-native, microservices-driven platform optimized for balance-and-valuation workflows. [cite: 11]

#### Architecture Data Flow:
`[Upstream Data Aggregators] -> [REST / JSON Secure API Gateways] -> [InvestCloud Wealth Data Platform (WDP)] -> [Algorithmic Rule & Parameter Engine] -> [True Exception Management View Layer] -> [Output: White-Label Interactive Portals]` [cite: 11]

AdvantageFee operates via clear microservices, utilizing modern web frameworks and highly optimized data pipelines to run scalable logic against complex portfolio allocations, corporate accounting trees, and investment fee profiles. [cite: 11]

#### Central Operations Control Panel (True Exception Management UI)
```text
INVESTCLOUD ADVANTAGEFEE:: CENTRAL OPERATIONS CONTROL PANEL [EXCEPTION BOARD]
| [ICON] DASHBOARD [ICON] ASSET_TREES [ICON] RULE_CONFIGURATOR [ICON] INVOICE_PORTAL [LOGOUT] |
SYSTEM ALERTS OVERVIEW: |
[!! 4 CRITICAL BILLING EXCEPTIONS] [ OK: 14,210 Accounts Validated ] [ 99.85% Data Completeness] |
| ACTIVE RUN TRACKER: FUND ADMINISTRATION STRUCTURES |
Account Name                     Exception Flag         Drift Metric   Action Panel
BOA_CIB_MASTER_FEEDER_ALPHA      [MISSING ASSET VALUE]  -9.42% Var     [ MANUAL OVERRIDE RUN ]
BOA_CIB_EUROPEAN_GROWTH_CLASS_C  [BENCHMARK DRIFT DETECT] Formula Mism  [ RESTORE HISTORICAL BAL]
DIGITAL STATEMENT PREVIEW LOOP |
Institutional Framework: Master Group Umbrella Tree |
Asset-Under-Management Allocation (AUM): $14,290,500,000 |
Programmatic Performance Hurdle Rule: 15% Over HWM Index |
Automated Net Invoiced Calculations: $2,410,500.00 [ VIEW TEMPLATE / PRE-DELIVERY SIGN-OFF]
```
*Note: The AdvantageFee platform prioritizes high-level process exception management over tabular logs. It focuses on identifying valuation gaps and structural drift anomalies across asset profiles to prevent invoicing errors before presentation.* [cite: 10]

---

## 3. Deep Technical Feature Alignment

| Workflow / Module | Oracle ORMB Infrastructure Capability | InvestCloud AdvantageFee Infrastructure Capability |
| :--- | :--- | :--- |
| **Custody & Safekeeping Billing** | Highly powerful engine for complex multi-jurisdictional custody structures, sub-custodian cost calculations, and massive transaction-volume pricing. Processes millions of daily trades via staging frameworks and applies precise volume tiering. [cite: 9, 10, 11] | Strong out-of-the-box templates for tiered asset-under-custody (AUC) fees, basis point schedules, and safe-keeping visual models. Ingests monthly aggregated transaction volumes, applying tiered rates to valuation states rather than raw execution streams. [cite: 9, 10, 11] |
| **Fund Accounting** | Acts as an independent sub-ledger, matching general ledger data entries against custom corporate accounting matrices. Capable of executing sophisticated calculation logic for large institutional fund structures. [cite: 10, 11] | Excellent visual tools for standard management fees, performance fees (high-water marks), and intuitive multi-class sharing rules. Natively maps nested legal structures, including Master-Feeder allocations, distinct asset classes, and complex performance fees. [cite: 9, 10, 11] |
| **Collateral Management** | Tracks volatile margin balances using automated sub-second transactional calculation loops. Ingests margin call flags, tri-party arrangement data, and optimization fees, converting volatile operational data into clear line-item totals. [cite: 10, 11] | Good at client-facing statements and transparent breakdown of collateral optimization fees or financing rates. Applies structural fee metrics to position balances captured at designated month-end reporting marks. [cite: 9, 10, 11] |
| **Accrual & Balance Control / ECR** | Features a dedicated Earnings Credit Rate (ECR) engine that calculates balance offsets from corporate Demand Deposit Accounts (DDA) to mitigate fee totals using precise day-count conventions before invoice finalization: <br><br>$$Fee_{Net} = Fee_{Gross} - \left(Balance_{Avg} 	imes Rate_{ECR} 	imes rac{t}{360}
ight)$$ [cite: 10, 11] | Performs real-time fee accrual calculations, allowing operational teams to run predictive revenue projections and track valuation gaps or structural drift anomalies natively. [cite: 10] |
| **Throughput Architecture** | High-volume database staging tables; handles millions of raw transactional rows via parallel batch jobs (primarily using the `CI_TXN_IN` interface). [cite: 11] | API-first engine; optimized for structured account balance records, aggregated value files, and JSON payloads. [cite: 10, 11] |
| **AI & Advanced Analytics** | Deep embedded machine learning capabilities through Oracle Data Intelligence, focusing on transactional anomaly detection, predictive pricing analytics, micro-leakage identification, and cash forecasting. [cite: 9, 11] | Strong focus on digital enablement, predictive analytics that forecast fee behavior, revenue leakage visualizations, intuitive digital assistants, and "What-If" rate simulation scenarios. [cite: 9, 11] |

---

## 4. Comprehensive Advantages & Disadvantages

### Product A: InvestCloud AdvantageFee
*   **▲ Advantages (Pros):**
    *   **Modern, Intuitive User Experience:** Offers an exceptional, out-of-the-box modern digital UI that requires minimal training for operational teams and provides sleek dashboards for executive oversight. [cite: 9]
    *   **Rapid Time-to-Market:** The solution features highly specific, pre-built templates for wealth and asset servicing workflows, allowing faster deployment for standard investment management setups. [cite: 9]
    *   **Client-Centric Transparency:** Excellent capabilities in generating highly visual, detailed, and easily digestible fee statements for institutional clients, reducing billing disputes. [cite: 9]
    *   **Flexible Relationship Pricing:** Allows relationship managers to model and simulate boutique, custom fee schedules directly through a visual sandbox environment. [cite: 9]
*   **▼ Disadvantages (Drawbacks):**
    *   **Scalability Limitations:** May face performance degradation when processing the massive, multi-million daily transaction volumes typical of Tier-1 global corporate banking. [cite: 9]
    *   **Bespoke Customization Complexity:** While standard asset management workflows are well-supported, deep customization for unique legacy enterprise frameworks can be challenging. [cite: 9]
    *   **Ecosystem Dependency:** Maximizing its value often leans heavily on adopting broader components of the InvestCloud digital ecosystem. [cite: 9]
    *   **Core GL Engine Depth:** The general ledger integration and deep accounting rule configuration engine are less mature compared to legacy enterprise giants. [cite: 9]

### Product B: Oracle Revenue Management and Billing (ORMB)
*   **▲ Advantages (Pros):**
    *   **Unparalleled Performance & Scale:** Proven architecture capable of processing massive transaction volumes seamlessly, making it the industry standard for large Tier-1 global corporate banks. [cite: 9]
    *   **Robust Rules & Accounting Engine:** Extremely detailed and robust general ledger configuration, capable of handling complex multi-currency, multi-entity, and complex regulatory accounting rule sets. [cite: 9]
    *   **Highly Extensible Architecture:** Designed to act as a highly customizable centralized platform that can interface with multiple disparate legacy core banking systems. [cite: 9]
    *   **Enterprise-Grade Security & Compliance:** Benefits from Oracle's extensive enterprise stack, providing rigorous compliance controls, audit trails, and multi-tenant security layers. [cite: 9]
*   **▼ Disadvantages (Drawbacks):**
    *   **Steep Learning Curve & Complex UI:** The native interface is often viewed as dense, highly technical, and less intuitive, requiring specialized training for operational users. [cite: 9]
    *   **High Total Cost of Ownership (TCO):** Implementation, licensing, infrastructure upkeep, and specialized developer resource costs are significantly high. [cite: 9]
    *   **Lengthy Implementation Timelines:** Deployments are typically large-scale enterprise projects that can stretch across many months or years due to the platform's complexity. [cite: 9]
    *   **Heavy Infrastructure Footprint:** Requires significant technical expertise to manage and optimize, especially when integrated across on-premises and hybrid cloud environments. [cite: 9]

---

## 5. Enterprise Pricing & Commercial Realities

### 5.1 Oracle ORMB Commercial Profile
*   **Licensing Structure:** Available as a Cloud Service (SaaS) or via traditional on-premises models. Enterprise licensing scales based on Processor Metrics or Volume Tiers (e.g., millions of transaction units processed per month). [cite: 11]
*   **Estimated License Costs:** Core software subscription ranges between **$1,500,000 – $3,500,000+ annually** for global transaction tiers, depending on deployment footprint and database sizing. [cite: 10, 11]
*   **Integration Multiplier:** **2.5x – 4.0x** the annual license fee. Requires specialized database tuning, complex custom configurations, infrastructure orchestration, and low-level data staging logic due to custom ledger mapping. [cite: 10, 11]
*   **System Dependency:** Deeply integrated and coupled with the Oracle tech and database ecosystem stacks (OCI, WebLogic, WebCenter, ETL engines, and messaging queues). [cite: 10, 11]

### 5.2 InvestCloud AdvantageFee Commercial Profile
*   **Licensing Structure:** Managed via a subscription-based SaaS framework determined by Assets Under Management (AUM) tiers or total active account volume processed across the network. [cite: 11]
*   **Estimated License Costs:** Software subscription rates typically range from **$800,000 – $2,000,000 annually**, scaling with aggregate institutional volume allocations. [cite: 10, 11]
*   **Integration Multiplier:** **1.0x – 1.5x** the annual software fee. Leverages standard integration layers, REST APIs for every platform view, clean JSON payloads, multi-custodial data streams, and out-of-the-box configuration templates. [cite: 10, 11]
*   **System Dependency:** Highly componentized but functions most cleanly when cleanly absorbing standard multi-custodial data streams. [cite: 10]

---

## 6. Strategic Evaluation: Build Your Own Custom Platform

To eliminate the drawbacks of both options—achieving the **scalability and regulatory depth of Oracle ORMB** alongside the **modern, client-centric UI/UX of InvestCloud**—an organization might consider building a proprietary platform ("AdvantageFee to cover all disadvantages"). Below is the financial and operational reality of a custom development approach. [cite: 12]

### 6.1 Estimated Capital Expenditure (CapEx) Breakdown
*   **Phase 1: Architecture & Compliance Scoping ($50,000 – $80,000)**
    *   *Scope:* Data pipeline scoping, ledger interface definitions, security compliance mapping (SOC 2, PCI-DSS), and local multi-jurisdictional regulatory logic. [cite: 12]
*   **Phase 2: Core Calculation Engine ($200,000 – $400,000)**
    *   *Scope:* Building high-performance, multi-threaded batch processors (e.g., Java/Spring Boot, Apache Kafka) to handle high-frequency basis-point splits, custody tiers, and volatile fund accounting rules without latency. [cite: 12]
*   **Phase 3: Frontend & Visualization Dashboard ($100,000 – $200,000)**
    *   *Scope:* Developing a React-based dynamic user dashboard, client invoicing views, visual data panels, and relationship pricing sandboxes. [cite: 12]
*   **Phase 4: QA & Volume Stress-Testing ($100,000 – $150,000)**
    *   *Scope:* Simulating multi-million transaction days to ensure zero-drift accounting rules, high-throughput elasticity, database isolation, and security hardening. [cite: 12]
*   **Total Initial Build Cost: $450,000 – $930,000+**
    *   *Timeframe:* Requires an estimated internal engineering runway of **12 to 18 months**. [cite: 12]

### 6.2 Ongoing Operational Expenditure (OpEx)
Beyond the initial build, a custom engine requires an annual maintenance budget equal to **15% to 20% of the initial build cost ($70,000 – $180,000+/year)**. This funds ongoing cloud resource auto-scaling, security updates, compliance modifications, patch management, and general ledger integrity upkeep. [cite: 12]

### 6.3 Strategic Trade-Off Analysis

| Strategy | Strategic Merits (Pros) | Operational Risk & Imperfections (Cons) |
| :--- | :--- | :--- |
| **Build a Proprietary Tool** | Perfect custom workflow fit tailored exactly to internal business requirements. Zero ongoing vendor license markups. Total control over product roadmap, UI enhancements, and technical stack optimization. [cite: 12] | Massive upfront CapEx. Slowest time-to-market (12–18 months). The organization takes on 100% of the engineering risk, compliance liabilities, system bugs, and calculation drift failures. [cite: 12] |
| **Buy an Off-the-Shelf Core** | Tested global infrastructure framework with proven scalability. Fast to medium time-to-market. Core security updates and multi-entity regulatory configurations are managed entirely by the vendor. [cite: 12] | High recurring software license TCO. Inevitable operational workarounds for missing features. Dependent on external vendor roadmaps for required enhancements. [cite: 12] |

---

## 7. Final Architectural Recommendation Summary

For an institutional-scale corporate and investment banking workflow, **building a custom ledger calculation engine entirely from scratch is rarely economically or operationally justifiable.** The math, multi-currency compliance tracking, and technical scaling parameters required are an intense operational burden. The core focus of a financial institution should remain asset servicing and transaction banking, not backend core-ledger system engineering. [cite: 12]

The choice between the two market leaders for buying depends heavily on line-of-business architecture requirements:
1.  **Select Oracle ORMB** if standardizing billing for high-volume corporate networks, cash management systems, or global payment clearings that require heavy, transaction-level batch processing. [cite: 11]
2.  **Select InvestCloud AdvantageFee** if deploying within asset servicing, institutional fund accounting, or trust structures that require flexible, rule-based fee logic, automated exception tracking, and modern client portals. [cite: 11]

### The Optimal Blueprint: The Hybrid Approach ("Buy the Core, Build the Edge")
Instead of wasting capital building a brand-new tool from scratch to cover the gaps, the most efficient and risk-averse framework is to merge both strategies:
*   **Buy the Core Core:** Deploy an established transaction engine like **Oracle ORMB** to handle the heavy, high-volume transactional calculations, sub-second ledger processing, and general ledger integration. [cite: 12]
*   **Build the Edge UI:** Construct a lightweight, specialized, modern client web interface or dashboard **internally utilizing open APIs**. This allows your operations team to leverage the unbreakable calculation stability and scaling power of an ORMB core while circumventing its complex UI drawbacks—delivering the visual elegance of an InvestCloud ecosystem without risking a million-dollar engine failure. [cite: 12]
