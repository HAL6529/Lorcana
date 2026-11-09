using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_02 : CardInfo
{
    public CardInfo_103_JA_02()
    {
        this.cardNo = "103_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バルー";
        this.cardName2 = "楽しいこと好きのクマ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.R_laBarberaAndL_Giammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
