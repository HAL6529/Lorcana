using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_06 : CardInfo
{
    public CardInfo_006_JA_06()
    {
        this.cardNo = "006_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "チップ";
        this.cardName2 = "真の友";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
