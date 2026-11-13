using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_07 : CardInfo
{
    public CardInfo_176_JA_07()
    {
        this.cardNo = "176_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マリアン姫";
        this.cardName2 = "特技はバドミントン";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EmilyAbeydeera;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
