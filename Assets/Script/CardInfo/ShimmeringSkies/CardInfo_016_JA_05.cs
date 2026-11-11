using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_05 : CardInfo
{
    public CardInfo_016_JA_05()
    {
        this.cardNo = "016_JA_05";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "ドナルドの彼女";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrancescoDippolitoAndGiuseppeDiMaio;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
