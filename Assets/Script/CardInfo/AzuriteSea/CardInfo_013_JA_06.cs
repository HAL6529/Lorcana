using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_06 : CardInfo
{
    public CardInfo_013_JA_06()
    {
        this.cardNo = "013_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "モンタリー・ジャック";
        this.cardName2 = "快男児のレンジャー";
        this.power = 0;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
