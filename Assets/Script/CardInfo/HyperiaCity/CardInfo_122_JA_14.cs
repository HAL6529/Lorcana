using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_14 : CardInfo
{
    public CardInfo_122_JA_14()
    {
        this.cardNo = "122_JA_14";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トランプ";
        this.cardName2 = "頼りになるやつ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DaniFdezAndGregShrader;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
