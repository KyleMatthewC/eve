using System;
using System.Collections.Generic;
using System.Text;

namespace Eve.Mock_Data
{
    class Filler
    {
        public CriteriaMap FillCriteriaMap()
        {
            CriteriaMap criteriaMap = new CriteriaMap();

            // Accountability
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.IndividualContributor12),
                @"'- Work on defined and standard tasks with regular guidance from the lead
                - Follow the proper task prioritization as discussed with leads
                - Perseveres through tasks and execute them in detail and completely.
                - Adheres to company and team processes
                ");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.IndividualContributor11),
                @"'- Work on defined and standard tasks with occasional guidance from the lead
                - Can manage own workload by properly prioritizing tasks assigned, consult with lead when in doubt. 
                - Committed items should be delivered on time, and proactively communicate when deliverables cannot be met
                - Adhere to process and policies defined within the team.");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.IndividualContributor10),
                @"'- Takes note of the scheduled delivery timeline for the work items assigned
                - Can manage own workload by balancing different releases and tasks (issues vs. coding tasks) properly
                - Work output should be in high quality adhereing to quality targets set by the team");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.IndividualContributor9),
                @"' - Can manage own workload by balancing different releases and tasks , all items should be completed on time or communicate adjustments accordingly
                - Is expected to juggle different requests from different teams (can be outside of the development team)
                - Work output should be in high quality adhering to quality targets set by the team");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.SrDeveloper8),
                @"'- Can manage own workload by balancing different releases and tasks , all items should be completed on time or communicated adjustments accordingly
                - Is expected to juggle different requests from different teams (can be outside of the development team)
                - Work output should be in high quality adhering to quality targets set by the team");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.TeamLead9),
                @"'-Actively monitors tasks for the team, takes note of the schedule deadlines and prioritize work accordingly
                - Monitors overall code quality for the team, provide appropriate metrics and status as necessary");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.SeniorTeamLead9),
                @"'- Actively monitors tasks for the team, communicate concerns with meeting deadlines to stakeholders like PMs, leads and counterparts in a timely manner
                - Ensure that all people within the team can deliver their committed tasks. Find solution to constraints such as lacking of developers etc
                -Double check resource capacity and ensure that people are not over worked or under utilized
                - Takes note of critical timeline for milestones like release dates, performance evaluation, training etc
                ");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.Manager7),
                @"'-Actively monitors workloads for a group of teams, coordinate with leads within the team then to external stake holders like PM.
                - Plan for resource concerns for the overall team deliverables, consider alternatives to pick the best plan of approach among the alternatives considered
                - Can determine the right priorities for the teams to take in the midst of competing priorities. 
                - Quality work output for all the teams assigned in terms of FRDs, CADs, INCs, and tasks.");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.ArchitectManager7),
                @"'- Can manage an entire product or multiple products at the same time, managing multiple big enhancements at the same time
                - Can monitor a group of developers working on the same product and ensures that all projects are implemented correctly in terms of functionality
                - Should be readily available for consultation from the people within the group, can effectively shift tasks as necessary
                - Can properly manage competing demands and prioritize tasks accordingly");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.JrArchitect8),
                @"'- Can handle more than 1 big project at the same time
                - Can monitor a group of developers working on the same work item and ensuring that everyone is completing their tasks assigned according to schedule
                - Can manage multiple competing requests in a given time
                - Work output should be in high quality adhering to quality targets set by the team");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Accountability, TeamRole.Architect7),
                @"'- Can manage an entire product or multiple products at the same time, managing multiple big enhancements at the same time
                - Can monitor a group of developers working on the same product and ensures that all projects are implemented correctly 
                - Can properly manage competing demands and prioritize tasks accordingly
                - Work output should be in high quality adhering to quality targets set by the team");

            // BusinessAcumen
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.IndividualContributor12),
                @"- Completes all required trainings by the company
                - Takes time to understand the expected behavior of the system for the task assigned
                - Be able to answer basic functionality questions about the product assigned through code check"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.IndividualContributor11),
                @"- Should exercise a level of depth in functional knowledge. Developer have the capacity to comprehend similar work items in the past and apply the same learning in the new task.
                - Can properly communicate acquired knowledge to others through written and verbal channels."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.IndividualContributor10),
                @"- Has sufficient knowledge in supporting a particular area of a sub-product. Can take care of all aspects regarding this particular functionality (for example Bagtags inSkyPort)
                - Keeps self up to date on all the issues and enhancements  around that particular functional area
                - Can function as a CR owner and provides proposed solution on FRDs and design CAD functionality within the area
                - Pro-actively raise important issues from the requirements/solution "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.IndividualContributor9),
                @" - Has sufficient understanding on the functional area assigned to the developer appropriate in this level. 
                - Can participate on functional discussions about a portion of the product and drive the direction of work items as necessary
                - Leverage on experience to provide speedy resolution of issues
                - Pro-actively raise important issues from the requirements/solution provided as necessary
                - Can provide valuable training  about the product or the technology when necessary."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.SrDeveloper8),
                @"- Has sufficient understanding on the functional area assigned to the developer appropriate in this level. 
                - Can participate on functional discussions about  the sub-product and drive the direction of the functionality for the work items as necessary
                - Leverage on experience to provide speedy resolution of issues
                - Pro-actively raise important issues from the requirements/solution provided as necessary
                - Can provide valuable training  about the product or the technology when necessary."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.TeamLead9),
                @" - Has sufficient understanding on the functional area assigned to the developer/team appropriate in this level. 
                - Can participate on functional discussions about a portion of the product and drive the direction of work items as necessary
                - Participate on majority of the FRD and CAD reviews for the team. Pro-actively provide inputs for improvement as appropriate.  Does impact analysis as appropriate
                - Keeps self up to date in terms of functionality in the product assigned
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.SeniorTeamLead9),
                @"- Has a good grasp of the functionality of the sub-product assigned. Work closely with teammates or leads when lacking full knowledge and expertise on the team functionality
                - Can participate during reviews and provide valuable insights as appropriate
                - Keep self up to date in terms of product functionality when time permits
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.Manager7),
                @"-Has a good grasp of the functionality of the sub-product assigned. Work closely with teammates or leads when lacking full knowledge and expertise on the team functionality, participate in reviews as appropriate
                - Has deep understanding of the process and procedures in the company and can make wise decisions related to it."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.ArchitectManager7),
                @"- Provides guidance and sets the direction of the architecture of 1 or more sub-products
                - Be available for all forms of consultation from the team, other DEV teams, and other teams
                - Has deep understanding on the systems assigned to the architect
                - Can provide high-quality solutions on the product
                - Drives the direction of the product/functional assigned in terms of solutions created for various requests.
                - Actively attends  FRD and CAD reviews for the area of expertise 
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.JrArchitect8),
                @"- Provides guidance and sets the direction of the architecture of 1 or more sub-products
                - Be available for all forms of consultation from the team, other DEV teams, and other teams
                - Has deep understanding on the systems assigned to the architect
                - Can provide high-quality solutions on the product
                - Drives the direction of the product/functional assigned in terms of solutions created for various requests.
                - Actively attends  FRD and CAD reviews for the area of expertise 
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BusinessAcumen, TeamRole.Architect7),
                @"- Good in depth knowledge in terms of the system. Should have significant experience in supporting the system or related functionality and can easily respond to queries from the team  with minimal time and research.
                - Good level of understanding about the industry and how our products comes into play for our client’s businesses. Good level of understanding of client’s needs and usage of the system
                - Can provide good solutions for the system and be able to properly measure the impact of the solution in the system as well as other products potentially affected by the change. 
                - Drive the overall direction of the system owned and represent this properly to internal and external clients.
                - ctively attends FRD and CAD reviews for the area of expertise"
                );

            // TechnicalExcellence
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.IndividualContributor12),
                @"- Pass C# and other related trainings within 2 takes
                - Be able to properly troubleshoot issues on the code, design are often provided already
                - Understand basic programming concept and straight forward standards and patterns defined in the code
                - Codes should be clean and understandable, no major blocking issues such as infinite loops
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.IndividualContributor11),
                @"- Be able to properly troubleshoot issues on the code for the tasks assigned
                - Can provide code solution in tasks assigned  following the standard coding patterns in the code
                - Codes should be understandable, easy to maintain and learning from past issues encountered
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.IndividualContributor10),
                @"- Understands the overall architecture approach for the sub-product assigned
                - Can design CADs for work items assigned with complexity appropriate for this level. 
                - Can introduce non-standard logic into the code that will still be in line with the code architecture approach
                - Takes consideration on more complex technical aspects like code re-usability"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.IndividualContributor9),
                @"- Understand the overall architecture approach of the systems assigned
                - Can design CADs for work items assigned with complexity appropriate for this level, can also design tasks for other developers to code on
                - Can introduce non-standard logic into the code that will still be in line with the code architecture approach. 
                - Code structure should provide a level of maturity taking into considerations things like optimized code and performance"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.SrDeveloper8),
                @"- Understand the overall architecture approach of the systems assigned
                - Can design CADs for work items assigned with complexity appropriate for this level, can also design tasks for other developers to code on
                - Can introduce non-standard logic into the code that will still be in line with the code architecture approach. 
                - Code structure should provide a level of maturity taking into considerations things like optimized code and performance"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.TeamLead9),
                @"- Can design CADs for work items assigned with complexity appropriate for this level, can also design tasks for other developers to code on
                - Personal code output should be done correctly and in good quality.
                - Participate on Code reviews for the entire team when necessary ensuring that all codes output of the team are working as expected
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.SeniorTeamLead9),
                @"- Can design CAD and code as necessary for personal assigned tasks. Output should be correct and working in a quality expected for this level
                - Participate on CAD and code reviews when available, provide valuable guidance. 
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.Manager7),
                @"-Has a good grasp on the product’s code architecture. Work closely with teammates or leads when lacking full knowledge, participate in reviews as appropriate
                - Can guide younger team members in the process
                - Keeps self up to date on the happenings of the application"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.ArchitectManager7),
                @"- Be able to independently handle technical design tasks appropriate for this level or  that have inter dependence with other products
                - Code designs should be strong architecturally (adhering to standards/NCA, factoring performance, easy to maintain, future proof, learning from experience, re-usable, etc)
                - Participate heavily during FRD and CAD review providing valuable inputs to code architecture
                - Be able to define patterns and standards for the rest of the team to follow; also participate in major refactoring effort to improve code architecture and performance
                - Be able to troubleshoot technically complex tasks – such as performance issues, memory leakage etc
                - Maintaining in-depth knowledge on the technologies used in building the product and providing elegant solution"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.JrArchitect8),
                @"- Be able to independently handle technical design tasks appropriate for this level or  that have inter dependence with other products
                - Code designs should be strong architecturally (adhering to standards/NCA, factoring performance, easy to maintain, future proof, learning from experience, re-usable, etc)
                - Participate heavily during FRD and CAD review providing valuable inputs to code architecture
                - Be able to define patterns and standards for the rest of the team to follow; also participate in major refactoring effort to improve code architecture and performance
                - Be able to troubleshoot technically complex tasks – such as performance issues, memory leakage etc
                - Maintaining in-depth knowledge on the technologies used in building the product and providing elegant solution
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TechnicalExcellence, TeamRole.Architect7),
                @"- Participate heavily during FRD and CAD review providing valuable inputs to code architecture
                - Define patterns and standards for the rest of the team to follow; also participate in major refactoring effort to improve code architecture and performance
                - Define coding standards and practices that will also cover complext technical tasks - such as performance , memory management, cloud, caching etc. 
                - Maintaining in-depth knowledge on the technologies used in building the product and providing elegant solution
                - Always keeps self up to date with latest trends in technology and ensures that our team is moving forward with it."
                );

            // CustomerFocus
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.IndividualContributor12),
                @"- Perform due diligence in reviewing all of the details during investigation
                - Take time to understand the rationale of the request
                - Provide updates with facts and evidences and write in clear manner"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.IndividualContributor11),
                @"- Perform due diligence in reviewing all of the details during investigation
                - Take time to understand the rationale of the request
                - Provide updates with facts and evidences and write in clear manner"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.IndividualContributor10),
                @" - Understand the client's business and communicate it in a way that they will understand
                - Be able to assist in critical issues and help find the root cause of the issue
                - Respond in a timely manner"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.IndividualContributor9),
                @"- Able to provide support during customer outage situation or critical incidents
                - Understand the client's business and communicate it in a way that they will understand
                - Be able to find root cause and provide workaround and proposed solution
                - Respond in a timely manner and demonstrating ownership of the issues"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.SrDeveloper8),
                @"- Able to provide support during customer outage situation or critical incidents
                - Understand the client's business and communicate it in a way that they will understand
                - Be able to find root cause and provide workaround and proposed solution
                - Respond in a timely manner and demonstrating ownership of the issues"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.TeamLead9),
                @"- Able to provide support during customer outage situation or critical incidents
                '- Help team understand rationale behind customer requests and respond accordingly
                - Follow up on customer issues until resolved
                - Meets customer requirements and expectations timely and consistently"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.SeniorTeamLead9),
                @"- Help team understand rationale behind customer requests and respond accordingly
                - Follow up on customer issues until resolved
                - Meets customer requirements and expectations timely and consistently"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.Manager7),
                @"- Follow up on customer issues until resolved
                - Makes sure the team meets customer requirements and expectaitons timely and consistently
                - Seeks feedback on the performance of the team
                - Effectively use the team to AddCriteriaress customers needs and seeks team alignment"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.ArchitectManager7),
                @"- Follow up on customer issues until resolved
                - Makes sure the team meets customer requirements and expectaitons timely and consistently
                - Effectively use the team to AddCriteriaress customers needs and seeks team alignment"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.JrArchitect8),
                @"- Has a good understanding of client’s needs and why clients are requesting for certain features and not just take thing as it is.
                - Can effectively coordinate with clients when necessary
                - Follow up customer issues until resolved
                - Meets customer requirements and expectations timely and consistently"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.CustomerFocus, TeamRole.Architect7),
                @"- Should be readily available for consultation from the people within the group, can effectively shift tasks as necessary
                - Be able to represent the product and Navitaire during customer issues, change requests or other meetings
                - Timely update and demonstrating empathy to our customer's needs
                - Provide expertise to customers even in dealing with non-system specific requests (consulting)."
                );

            // Communication
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.IndividualContributor12),
                @"- Provides regular updates and status on work items
                - Communicates work items properly
                - Document learning for future reference and knowledge sharing
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.IndividualContributor11),
                @"- Provides regular updates on work items
                - Communicate work items properly
                - Document learning for future reference
                - Interact with different teams like QA and Product"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.IndividualContributor10),
                @"- Can properly coordinate tasks among different developers working on the same issue. Complexity of tasks is within those expected on this level.
                - Can coordinate with different stakeholders regarding the issue or work item worked on"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.IndividualContributor9),
                @"- Can properly coordinate tasks among different developers working on the same issue. Complexity of tasks is within those expected on this level.
                - Can coordinate with different stakeholders regarding the issue or work item worked on"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.SrDeveloper8),
                @"- Can properly coordinate tasks among different developers working on the same issue. Complexity of tasks is within those expected on this level.
                - Can coordinate with different stakeholders regarding the issue or work item worked on"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.TeamLead9),
                @"- Actively communicate concerns with meeting deadlines to stakeholders like PMs, leads and counterparts in a timely manner
                - Sends regular status reports to involved parties
                - Heads scrums for the team to make sure critical issues are properly discussed and coordinated.
                - Can properly coordinate various tasks for the team with each stake holders accordingly
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.SeniorTeamLead9),
                @"- Actively communicate concerns with meeting deadlines to stakeholders like PMs, leads and counterparts in a timely manner
                - Sends regular status reports to involved parties
                - Heads scrums for the team to make sure critical issues are properly discussed and coordinated.
                - Can properly coordinate various tasks for the team with each stake holders accordingly
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.Manager7),
                @"- Actively communicate the state and future plans of the teams to key stake holders such as senior managers, counterparts, senior leadership
                - Assertive in raising team concerns to the parties involved seeking and participating in resolution of concerns
                - Manage escalations from various teams and make sure that they are properly AddCriteriaressed"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.ArchitectManager7),
                @"- Actively communicate concerns with meeting deadlines to stakeholders like PMs, leads and counterparts in a timely manner
                - Sends regular status reports to involved parties
                - Heads scrums for the team to make sure critical issues are properly discussed and coordinated.
                - Can properly coordinate various tasks for the team with each stake holders accordingly
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.JrArchitect8),
                @"- Can properly coordinate tasks among different developers working on the same issue. Complexity of tasks is within those expected on this level.
                - Can coordinate with different stakeholders regarding the issue or work item worked on
                - Sends regular status reports to involved parties"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Communication, TeamRole.Architect7),
                @"- Can properly coordinate tasks among different developers working on the same issue. Complexity of tasks is within those expected on this level.
                - Can coordinate with different stakeholders regarding the issue or work item worked on
                - Sends regular status reports to involved parties"
                );

            // BuildingRelations
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.IndividualContributor12),
                @"- Build good relationship with team lead, career counselor and other relevant mentor
                - Maintain positive interaction/communication with teammates, internal clients (QA, Prod etc), and external clients
                - Participates in people initiatives done within the team
                - Offer flexibility to the team to assist where needed when needed"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.IndividualContributor11),
                @"- Build good relationship with team lead, career counselor and other relevant mentor
                - Maintain positive interaction/communication with teammates, internal clients (QA, Prod etc), and external clients
                - Participate in people initiatives done within the team
                - Offer flexibility to the team to assist where needed when needed"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.IndividualContributor10),
                @"- Maintain peer level relationship with people among the same sub-product.  Can expand relationships to other teams as well such as QA, Product, Clients etc. 
                - Can provide guidance to new members of the team in their assigned tasks
                - Offer flexibility to the team to assist where needed when needed"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.IndividualContributor9),
                @"- Can guide newer members of the team in going about tasks or issues assigned
                - Can provide valuable opinion to AddCriteriaress issues encountered by other team members. 
                - Expand network to teammates globally
                - Can participate and lead in people initiative and other team initiatives
                - Openly provide assistance where it is needed by the team – covering various work items not only big high profile work items all the time
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.SrDeveloper8),
                @"- Can guide newer members of the team in going about tasks or issues assigned
                - Can provide valuable opinion to AddCriteriaress issues encountered by other team members. 
                - Expand network to teammates globally
                - Can participate and lead in people initiative and other team initiatives
                - Openly provide assistance where it is needed by the team – covering various work items not only big high profile work items all the time
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.TeamLead9),
                @"- Set as objectives reviewer for a reasonable members of the team (1-4), can act as career counselors for people at least 2 levels below (G,F)
            - Conducts regular checkpoint meetings with staff and make sure issues are AddCriteriaressed accordingly
            - Coordinates with lead on the direction of the people and the team
            - Actively collaborate with US lead counterparts to plan work work item and team direction"
            );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.SeniorTeamLead9),
                @"-Set as objectives reviewer or career counselor for a number of members in the team (1-8)
                - Conducts regular checkpoint meetings with staff and make sure issues are AddCriteriaressed accordingly (performance concerns, action plans, developmental needs)
                - Serve as career counselors to various team leads as necessary
                - Can properly guide younger members of the team in their tasks and help bring up their level of understanding and maturity in their TeamRole
                -Coach younger leads in their TeamRole and responsibility. Actively share experiences and recommendations on how to go about their situations
                -Have an accurate measure of people’s capabilities and provide coaching and training as necessary to raise level up
                - Expand network to teammates globally, working collaboratively with the other leads for overall approach on the team
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.Manager7),
                @"-Set as objectives reviewer or career counselor for a number of members in the team (4-20)
                -Lead a group of leads in levels D and C, also server as career counselors for the group, Keep engagement high in the team. 
                - Effectively mentor people within or outside the team managed. Can mentor people on all levels as necessary – 12 to 8
                - Expand network and influence across the organization and globally. Take an active part in matters that deals within their scope of their responsibility and to the organization as a whole.
                - Build long-term and trusting relationships with team members, team leads, peers, supervisors, counterparts, customers etc.
                - Able to sustain employee engagement and retention in the organization
                - Build present and future leaders in the organization
                - Build a strong culture and help promote the core values of the organization"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.ArchitectManager7),
                @"- Can be an objectives developer or career counselor of a small group of people (1 to 10)
                - Conducts regular checkpoint meetings with staff and make sure issues are AddCriteriaressed accordingly
                - Serve as career counselors to various team leads as necessary
                - Can properly guide younger members of the team in their tasks and help bring up their level of understanding and maturity in their TeamRole
                -Coach younger leads in their TeamRole and responsibility. Actively share experiences and recommendations on how to go about their situations
                -Have an accurate measure of people’s capabilities and provide coaching and training as necessary to raise level up
                - Expand network to teammates globally, working collaboratively with the other leads for overall approach on the team"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.JrArchitect8),
                @"- Can serve as supervisor to up to 4 developers. 
                - Conducts regular checkpoint meetings with staff and make sure issues are AddCriteriaressed accordingly. 
                - Can serve as mentors to others within this level of expertise.
                - Build individual contributors into architects similar to them
                - Expand network to work with architects globally, and  be approachable and available for team mates"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.BuildingRelations, TeamRole.Architect7),
                @"- Can serve as supervisor to up to 4 developers. 
                - Conducts regular checkpoint meetings with staff and make sure issues are AddCriteriaressed accordingly. 
                - Can serve as mentors to others within this level of expertise.
                - Build individual contributors into architects similar to them
                - Expand network to work with architects globally, and  be approachable and available for team mates
                - Assists people in the team greatly in terms of decisions within the area of subject matter expertise
                "
                );

            // LeadingSelf
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.IndividualContributor12),
                @"- Open and receptive to feedback, should have evidences of improvement for areas identified by lead. 
                - Pro-active in documenting learning, asking questions and raising potential issues and concerns. 
                - Takes note of areas for improvement and takes it upon self to be better"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.IndividualContributor11),
                @"- Open and receptive to feedback, should have evidences of improvement for areas identified by lead. 
                - Pro-active in documenting learning, asking questions and raising potential issues and concerns. 
                - Takes note of areas for improvement and takes it upon self to be better"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.IndividualContributor10),
                @"- Open and receptive to feedback, should have evidences of improvement for areas identified by lead. 
                - Pro-active in documenting learning, asking questions and raising potential issues and concerns. 
                - Takes note of areas for improvement and takes it upon self to be better"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.IndividualContributor9),
                @"- Demonstrate opennes during discussions especially in dealing with opposing ideas
                - Proper time management
                - Can say no when we are at risk of over committing
                - Can make the unpopular difficult choices
                - Set self up as good TeamRole model for younger developers to follow.
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.SrDeveloper8),
                @"- Demonstrate opennes during discussions especially in dealing with opposing ideas
                - Proper time management
                - Can say no when we are at risk of over committing
                - Can make the unpopular difficult choices
                - Set self up as good TeamRole model for younger developers to follow.
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.JrArchitect8),
                @"- Demonstrate opennes during discussions especially in dealing with opposing ideas
                - Proper time management
                - Can say no when we are at risk of over committing
                - Can make the unpopular difficult choices
                - Set self up as good TeamRole model for younger developers to follow.
                - Should be willing to extend a hand to the team when and where its needed"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.LeadingSelf, TeamRole.Architect7),
                @"- Demonstrate opennes during discussions especially in dealing with opposing ideas
                - Balance between control and delegation of work items
                - Proper time management
                - Can say no when we are at risk of over committing
                - Can make the unpopular difficult choices
                - Set self up as good TeamRole model for younger developers to follow.
                "
                );

            // TeamManagementandEngagement
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TeamManagementandEngagement, TeamRole.TeamLead9),
                @"- Can properly guide younger members of the team in their tasks and help bring up their level of understanding and maturity in their TeamRole
                - Identify areas for improvement and provide suggestions to help overall quality of team output
                - Align teams towards shifting priorities"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TeamManagementandEngagement, TeamRole.SeniorTeamLead9),
                @"- Effectively plan people’s career progression as well as other relevant opportunities such as on shore assignments
                - Anticipate risks in people and do redundancy planning as appropriate, keep engagement high
                - Motivate and encourage team members to be involved and progressive in their careers
                - Be able to properly balance delegation and control in the team
                - Provide assistance where it is needed by the team 
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TeamManagementandEngagement, TeamRole.Manager7),
                @"-Effectively plan and evaluate people’s  career progress, helping staff properly evaluate their strengths and weaknesses and pursue the appropriate career tracks. Also plan on relevant opportunities such as  promotion, on shore assignments etc
                - Have an accurate measure of people’s capabilities and provide coaching and training as necessary to raise level up
                - Strategize overall team growth. Effectively assess each areas of the team and determine the next steps. Always aiming for higher quality, moving up the value chain, expansion, knowledge retention . No attrition of critical resources and proper redundancy planning.
                - Promote proper usage of team budgets and make sure costs implications are taken into consideration when planning for opportunities."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.TeamManagementandEngagement, TeamRole.ArchitectManager7),
                @"- Effectively plan people’s career progression as well as other relevant opportunities such as on shore assignments
                - Anticipate risks in people and do redundancy planning as appropriate, keep engagement high
                - Motivate and encourage team members to be involved and progressive in their careers
                - Be able to properly balance delegation and control in the team
                - Provide assistance where it is needed by the team 
                "
                );

            // AnalyticalThinking
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.IndividualContributor12),
                @"-Codes should be working exactly as it is described on the work item. No obvious bugs or missed requirement from design should be found
                - Investigation should answer the immediate question or issue presented on the work item
                - Code testing should be conducted thoroughly and documented properly"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.IndividualContributor11),
                @"- Codes should be working exactly as it is described on the work item. No obvious bugs or missed requirement from design should be found
                - A level of Impact  analysis to the code changes should also be considered on the work item. Considers past knowledge and experience into the current issue.
                - Code testing should be conducted thoroughly and documented properly
                - Investigation items should identify primary root cause  within  his/her sub-product and communicated properly on updates.
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.IndividualContributor10),
                @"- FRD proposed solution, CADs and codes should be complete not missing a  requirement already defined in the FRD
                - Codes should be working and all related functionalities are properly considered, impact analysis is conducted in detail 
                - Can consider a variety of alternative approach and choose one best suited with the information on hand."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.IndividualContributor9),
                @"- FRD proposed solution and CADs should be complete not missing a  requirement already defined on the requirements
                - Can provide sensible estimates for personal tasks with complexity appropriate for this level. 
                - Codes should be working and all related functionalities are properly considered, impact analysis is conducted in detail "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.SrDeveloper8),
                @"- FRD proposed solution and CADs should be complete not missing a  requirement already defined on the requirements
                - Can provide sensible estimates for personal tasks with complexity appropriate for this level. 
                - Codes should be working and all related functionalities are properly considered, impact analysis is conducted in detail "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.TeamLead9),
                @"- FRD proposed solution and CADs should be complete not missing a  requirement already defined on the requirements
                - Design should be understandable by the team and can be delivered effectively. 
                - Estimates for work items assigned to the team should be within budget and should actively be improved.
                - Team output should all be working, not missing requirements and in good quality (bug free)
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.SeniorTeamLead9),
                @"-Monitors overall code quality for the team, provide appropriate metrics and status as necessary
                - Identify areas for improvement and provide suggestions to help overall quality of team output
                - Team output should all be working, not missing requirements and in good quality (bug free)
                - Estimates for work items assigned to the team should be within budget
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.ArchitectManager7),
                @"-Monitors overall code quality for the team, provide appropriate metrics and status as necessary
                - Identify areas for improvement and provide suggestions to help overall quality of team output
                - Team output should all be working, not missing requirements and in good quality (bug free)
                - Estimates for work items assigned to the team should be within budget
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.JrArchitect8),
                @"- Designs should be complete, well thought off, adhering to standards and not breaking other functionality.
                - FRDs and CADs created should be complete
                - If CR owner, overall code functionality should be working and complete
                - Output from the reviews should have sound, adhering to standards and complete (all related functionalities properly identified and fixed).
                - Estimates made for the entire team should be generally accurate. Work items are done on time and within budget
                - Can conduct in depth impact analysis on the product  and makes sure all related functionalities are properly covered"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AnalyticalThinking, TeamRole.Architect7),
                @"- FRDs and CADs created should be complete and not lacking of agreed functionality
            - Can consistently provide sensible estimates and can coordinate/validate estimates from other teams
            - Can effectively identify areas of concern and help the team plan accordingly 
            - Can demonstrate extensive knowledge of the system and quickly identify issues up front and areas to focus.
            - Codes should be working and all related functionality are properly considered, impact nalaysis is conducted in deep detail"
            );

            // AdaptabilityandFlexibility
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AdaptabilityandFlexibility, TeamRole.IndividualContributor12),
                @"- Independent attitude in figuring out things on their own is encouraged, but should also exercise appropriate judgment when its time to involve the leads
                ");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AdaptabilityandFlexibility, TeamRole.IndividualContributor11),
                @"- Independent attitude in figuring out things on their own is encouraged, but should also exercise appropriate judgment when its time to involve the leads
                ");
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AdaptabilityandFlexibility, TeamRole.IndividualContributor10),
                @"- Independent attitude in figuring out things on their own is encouraged, but should also exercise appropriate judgment when its time to involve the leads
                - Can contribute to a wide range of activities involved in the team by this time"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AdaptabilityandFlexibility, TeamRole.IndividualContributor9),
                @"- Openly provide assistance where it is needed by the team – covering various work items not only big high profile work items all the time
                - Be able to prioritize helping younger team members before self
                "
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.AdaptabilityandFlexibility, TeamRole.SrDeveloper8),
                @"- Openly provide assistance where it is needed by the team – covering various work items not only big high profile work items all the time
                - Be able to prioritize helping younger team members before self
                "
                );

            // ProblemSolving
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ProblemSolving, TeamRole.TeamLead9),
                @"-Provide assistance where it is needed by the team – covering various tasks such as coding, testing, training etc
                - Listen and understand their questions and concerns regarding their work items or other office related issues and find resolution
                - Be able to resolve team related issues
                - Lead and participate in various people and team initiatives"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ProblemSolving, TeamRole.SeniorTeamLead9),
                @"- Able to analyze and understand the different issues in the team whether its in work delivery, process, structure etc.
                - Listen and understand their questions and concerns regarding their work items or other office related issues and find resolution
                - Able to mediate to difficult issues and exercise judgement in its resolution
                - Lead and participate in various people and team initiatives"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ProblemSolving, TeamRole.Manager7),
                @"-Effectively manage conflicts and potential disagreement among the team or with other leads/managers in the organization. Help promote an overall better organization.
                - Effectively setup processes to safeguard quality output from the team, ensure improving metrics from the team.
                - Provide assistance where it is needed by the team  whatever type of support might be required.
                - Can identify and anticipate problems and come up with mitigations preferably before an escalation happens
                - Can come up with solution to a wide variety of vague problems and even consider alternatives 
                - Can make the hard/unpopular decisions when its the right thing to do"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ProblemSolving, TeamRole.ArchitectManager7),
                @"- Able to analyze and understand the different issues in the team whether its in work delivery, process, structure etc.
                - Listen and understand their questions and concerns regarding their work items or other office related issues and find resolution
                - Able to mediate to difficult issues and exercise judgement in its resolution
                - Lead and participate in various people and team initiatives
                - Effectively setup processes to safeguard quality output from the team, ensure improving metrics from the team.
                - Provide assistance where it is needed by the team  whatever type of support might be required."
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ProblemSolving, TeamRole.JrArchitect8),
                @"-Provide assistance where it is needed by the team – covering various tasks such as coding, testing, training etc
                - Listen and understand their questions and concerns regarding their work items or other office related issues and find resolution
                - Be able to resolve team related issues
                - Lead and participate in various people and team initiatives"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ProblemSolving, TeamRole.Architect7),
                @"-Provide assistance where it is needed by the team – covering various tasks such as coding, testing, training etc
                - Listen and understand their questions and concerns regarding their work items or other office related issues and find resolution
                - Be able to resolve team related issues
                - Lead and participate in various people and team initiatives"
                );

            // ChangeManagement
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ChangeManagement, TeamRole.SeniorTeamLead9),
                @"- Understand the team and company's goals and be able to effectively participate in its execution and achievement
                - Understand other's point of view open mindedly
                - Aligns team towards shifting priorities"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ChangeManagement, TeamRole.Manager7),
                @"- Ensures the entire team constantly follows policies within the team, strive to provide a good understanding to the people why certain things are in place.
                - Understand other's 'point of view', open minded
                - able to accept feedback constructively from own team/peers/management
                - Encourages and involves team members in introducing change
                - Align the team towards shifting priorities"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ChangeManagement, TeamRole.ArchitectManager7),
                @"- Understand the team and company's goals and be able to effectively participate in its execution and achievement
                - Understand other's point of view open mindedly
                - Aligns team towards shifting priorities"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ChangeManagement, TeamRole.JrArchitect8),
                @"- Understand the team and company's goals and be able to effectively participate in its execution and achievement
                - Understand other's point of view open mindedly
                - Aligns team towards shifting priorities"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.ChangeManagement, TeamRole.Architect7),
                @"- constantly review the current architecture of our system functionally and technically and to make sure we are taking advantage of relevant techonologies
                - lobby and introduce new concepts to be integrated to the organization. Conduct proper case study and provide proper business case to justify change
                - Provide proper training and guidelines on how to transition
                - Ensure that we have proper transition plans for those that might need to change technology and skillset
                - Align team towards shifting priorities"
                );

            // Innovation
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Innovation, TeamRole.Manager7),
                @"- Able to generate innovative ideas to new problems
                - Values ideas from team members
                - Create platform to lobby innovative ideas from the team to the right channel
                - Builds a team of analytical, innovative and independent thinkers while at the same time remaining to be collaborative to develop the best ideas"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Innovation, TeamRole.ArchitectManager7),
                @"- Able to generate innovative ideas to new problems
                - Values ideas from team members
                - Create platform to lobby innovative ideas from the team to the right channel
                - Builds a team of analytical, innovative and independent thinkers while at the same time remaining to be collaborative to develop the best ideas"
                );
            criteriaMap.AddCriteriaMessage(new Criteria(SpecificRole.Innovation, TeamRole.Architect7),
                @"- Able to generate innovative ideas to new problems
                - Participate heavily in innovation related activities such as hackathon ideaspace and come up with programs encouraging innovation in the team for product features and technology.
                - Values ideas from team members
                - Create platform to lobby innovative ideas from the team to the right channel
                - Builds a team of analytical, innovative and independent thinkers while at the same time remaining to be collaborative to develop the best ideas"
                );

            return criteriaMap;
        }
    }
}
