using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_07 : CardInfo
{
    public CardInfo_023_JA_07()
    {
        this.cardNo = "023_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "サンダーボルト";
        this.cardName2 = "世界一のスーパードッグ";
        this.power = 3;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxGrecke;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.PuppyShift3, EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
