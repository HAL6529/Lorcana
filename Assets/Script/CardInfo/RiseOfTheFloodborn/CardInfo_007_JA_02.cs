using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_02 : CardInfo
{
    public CardInfo_007_JA_02()
    {
        this.cardNo = "007_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉÜÅ[ÉhÉâ";
        this.cardName2 = "òrÇÃÇ¢Ç¢édóßÇƒâÆ";
        this.power = 1;
        this.toughness = 9;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
