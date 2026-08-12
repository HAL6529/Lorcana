using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_01 : CardInfo
{
    public CardInfo_057_JA_01()
    {
        this.cardNo = "057_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ワードローブ";
        this.cardName2 = "ベルのお世話役";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Giulia Riva";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
