using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_05 : CardInfo
{
    public CardInfo_122_JA_05()
    {
        this.cardNo = "122_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "デイジーの彼氏";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrancescoDippolitoAndGiuseppeDiMaio;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
