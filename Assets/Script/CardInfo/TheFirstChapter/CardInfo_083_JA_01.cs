using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_01 : CardInfo
{
    public CardInfo_083_JA_01()
    {
        this.cardNo = "083_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒWƒƒƒ“ƒo”ŽŽm";
        this.cardName2 = "”½‹t“I‰ÈŠwŽÒ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Milica Celikovic";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Alien, EnumController.Class.Inventor};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
