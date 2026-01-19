package testing.tests;

import com.tngtech.archunit.core.domain.JavaClasses;
import com.tngtech.archunit.core.importer.ClassFileImporter;
import com.tngtech.archunit.lang.ArchRule;
import org.junit.jupiter.api.Test;
import testing.ConsoleLogger;
import testing.ILogger;

import static com.tngtech.archunit.lang.syntax.ArchRuleDefinition.classes;
import static com.tngtech.archunit.lang.syntax.ArchRuleDefinition.noClasses;

public class ArchitectureTests {
    private final static String productiveCodePackage = "testing";
    private final static String testCodePackage = "testing.tests";

    @Test
    public void typesInProductiveCode_MustNotDirectlyAccessSystemOut() {
        ArchRule rule = noClasses()
                .that()
                .resideInAPackage(productiveCodePackage)
                .and()
                .doNotHaveSimpleName(ConsoleLogger.class.getSimpleName())
                .should()
                .accessField(System.class, "out");

        JavaClasses classes = new ClassFileImporter().importPackages(productiveCodePackage);

        rule.check(classes);
    }

    @Test
    public void testDoublesInTestCode_MustHavePrefixFakeInClassName() {
        ArchRule rule = classes()
                .that()
                .resideInAPackage(testCodePackage)
                .and()
                .implement(ILogger.class)
                .should()
                .haveSimpleNameStartingWith("Fake");

        JavaClasses classes = new ClassFileImporter().importPackages(productiveCodePackage, testCodePackage);

        rule.check(classes);
    }
}
