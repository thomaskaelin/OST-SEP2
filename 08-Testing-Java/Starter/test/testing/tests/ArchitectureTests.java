package testing.tests;

import com.tngtech.archunit.core.domain.JavaClasses;
import com.tngtech.archunit.core.importer.ClassFileImporter;
import com.tngtech.archunit.lang.ArchRule;
import org.junit.jupiter.api.Test;

import static com.tngtech.archunit.lang.syntax.ArchRuleDefinition.classes;
import static org.junit.jupiter.api.Assertions.fail;

public class ArchitectureTests {
    @Test
    public void typesInProductiveCode_MustNotDirectlyAccessSystemOut() {
        fail("Exercise 2: Verify that types in productive code do not access System.out");
    }

    @Test
    public void testDoublesInTestCode_MustHavePrefixFakeInClassName() {
        fail("Exercise 2: Verify that test doubles defined in test code have the prefix Fake in the class name");
    }
}
