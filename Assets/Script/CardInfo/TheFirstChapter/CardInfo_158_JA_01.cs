using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_01 : CardInfo
{
    public CardInfo_158_JA_01()
    {
        this.cardNo = "158_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉXÉJÅ[";
        this.cardName2 = "çïñã";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Bill Robinmson";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
