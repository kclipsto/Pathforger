using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathforger.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ancestries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdditionalLanguagesCount = table.Column<int>(type: "int", nullable: false),
                    CustomAdditionalLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalLanguages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoostsStrength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoostsDexterity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoostsConstitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flaws = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    AncestryRules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reach = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Backgrounds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Boosts0 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boosts1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainedSkillsCustom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainedSkillsLore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainedSkillsValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraitsRarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraitsValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundRules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backgrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasicActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FolderId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AncestryFeatLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassFeatLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillFeatLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillIncreaseLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralFeatLevels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvancedAttack = table.Column<bool>(type: "bit", nullable: false),
                    MartialAttack = table.Column<bool>(type: "bit", nullable: false),
                    SimpleAttack = table.Column<bool>(type: "bit", nullable: false),
                    UnarmedAttack = table.Column<bool>(type: "bit", nullable: false),
                    OtherAttackName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanAttack = table.Column<bool>(type: "bit", nullable: false),
                    HeavyDefense = table.Column<bool>(type: "bit", nullable: false),
                    MediumDefense = table.Column<bool>(type: "bit", nullable: false),
                    LightDefense = table.Column<bool>(type: "bit", nullable: false),
                    UnarmoredDefense = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    KeyAbility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perception = table.Column<int>(type: "int", nullable: false),
                    SavingThrowsFortitude = table.Column<int>(type: "int", nullable: false),
                    SavingThrowsReflex = table.Column<int>(type: "int", nullable: false),
                    SavingThrowsWill = table.Column<int>(type: "int", nullable: false),
                    CanSpellcast = table.Column<bool>(type: "bit", nullable: false),
                    AdditionalTrainedSkills = table.Column<int>(type: "int", nullable: false),
                    TrainedSkillsValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TraitsRarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraitsValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationValue = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overrides = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConditionIsValued = table.Column<bool>(type: "bit", nullable: false),
                    ConditionValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceChildren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceImmunityFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceOverriddenBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceOverrides = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BaseItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bulk = table.Column<int>(type: "int", nullable: false),
                    ContainerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hardness = table.Column<int>(type: "int", nullable: false),
                    HpMax = table.Column<int>(type: "int", nullable: false),
                    HpValue = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    MaterialGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentRarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentTraits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatValues",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prerequisites = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Counteraction = table.Column<bool>(type: "bit", nullable: false),
                    DefenseSave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefenseBasic = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationSustained = table.Column<bool>(type: "bit", nullable: false),
                    DurationValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Target = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundFeats",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundFeats", x => x.Key);
                    table.ForeignKey(
                        name: "FK_BackgroundFeats_Backgrounds_BackgroundEntityId",
                        column: x => x.BackgroundEntityId,
                        principalTable: "Backgrounds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SkillActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DC = table.Column<int>(type: "int", nullable: true),
                    CriticalSuccessEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuccessEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FailureEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriticalFailureEffect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillActions_BasicActions_Id",
                        column: x => x.Id,
                        principalTable: "BasicActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassRules",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ClassEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRules_Classes_ClassEntityId",
                        column: x => x.ClassEntityId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentRules",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EquipmentEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicationLicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationRemaster = table.Column<bool>(type: "bit", nullable: false),
                    PublicationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentRules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentRules_Equipment_EquipmentEntityId",
                        column: x => x.EquipmentEntityId,
                        principalTable: "Equipment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Feats",
                columns: table => new
                {
                    Uuid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FeatValueId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AncestryEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClassEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feats", x => x.Uuid);
                    table.ForeignKey(
                        name: "FK_Feats_Ancestries_AncestryEntityId",
                        column: x => x.AncestryEntityId,
                        principalTable: "Ancestries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feats_Classes_ClassEntityId",
                        column: x => x.ClassEntityId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Feats_FeatValues_FeatValueId",
                        column: x => x.FeatValueId,
                        principalTable: "FeatValues",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageDice = table.Column<int>(type: "int", nullable: false),
                    DamageDie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Predicate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Traits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentRuleEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Key);
                    table.ForeignKey(
                        name: "FK_DamageTypes_EquipmentRules_EquipmentRuleEntityId",
                        column: x => x.EquipmentRuleEntityId,
                        principalTable: "EquipmentRules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Runes",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Predicate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Selector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    EquipmentRuleEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runes", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Runes_EquipmentRules_EquipmentRuleEntityId",
                        column: x => x.EquipmentRuleEntityId,
                        principalTable: "EquipmentRules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundFeats_BackgroundEntityId",
                table: "BackgroundFeats",
                column: "BackgroundEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRules_ClassEntityId",
                table: "ClassRules",
                column: "ClassEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTypes_EquipmentRuleEntityId",
                table: "DamageTypes",
                column: "EquipmentRuleEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRules_EquipmentEntityId",
                table: "EquipmentRules",
                column: "EquipmentEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_AncestryEntityId",
                table: "Feats",
                column: "AncestryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_ClassEntityId",
                table: "Feats",
                column: "ClassEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Feats_FeatValueId",
                table: "Feats",
                column: "FeatValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Runes_EquipmentRuleEntityId",
                table: "Runes",
                column: "EquipmentRuleEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundFeats");

            migrationBuilder.DropTable(
                name: "ClassRules");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "Feats");

            migrationBuilder.DropTable(
                name: "Runes");

            migrationBuilder.DropTable(
                name: "SkillActions");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Backgrounds");

            migrationBuilder.DropTable(
                name: "Ancestries");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "FeatValues");

            migrationBuilder.DropTable(
                name: "EquipmentRules");

            migrationBuilder.DropTable(
                name: "BasicActions");

            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}
