using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_07 : CardInfo
{
    public CardInfo_173_JA_07()
    {
        this.cardNo = "173_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ƒWƒƒƒXƒ~ƒ“";
        this.cardName2 = "‚Ð‚ç‚ß‚«‚ÌŒ¤‹†ŽÒ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.YanoAndMilicaCelikovic;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
