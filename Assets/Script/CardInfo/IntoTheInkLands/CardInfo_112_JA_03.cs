using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_03 : CardInfo
{
    public CardInfo_112_JA_03()
    {
        this.cardNo = "112_JA_03";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "マダム・メデューサ";
        this.cardName2 = "ザ・ボス";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JackieDroujko;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
