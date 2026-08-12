using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_01 : CardInfo
{
    public CardInfo_008_JA_01()
    {
        this.cardNo = "008_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉãÅEÉtÉE";
        this.cardName2 = "Ç∑Ç¡Ç∆Ç±Ç«Ç¡Ç±Ç¢";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = "Andrey Chumak";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
