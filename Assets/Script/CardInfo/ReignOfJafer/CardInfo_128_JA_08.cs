using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_08 : CardInfo
{
    public CardInfo_128_JA_08()
    {
        this.cardNo = "128_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ルミエール";
        this.cardName2 = "すばやい燭台";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
