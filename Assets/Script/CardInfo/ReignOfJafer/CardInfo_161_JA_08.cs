using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_161_JA_08 : CardInfo
{
    public CardInfo_161_JA_08()
    {
        this.cardNo = "161_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ポット夫人";
        this.cardName2 = "家政婦長";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulieVu;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
