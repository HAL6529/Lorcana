using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_02 : CardInfo
{
    public CardInfo_176_JA_02()
    {
        this.cardNo = "176_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉVÉìÉfÉåÉâ";
        this.cardName2 = "ãRémå©èKÇ¢";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
