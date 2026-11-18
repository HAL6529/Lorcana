using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_08 : CardInfo
{
    public CardInfo_021_JA_08()
    {
        this.cardNo = "021_JA_08";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "カー";
        this.cardName2 = "催眠ニシキヘビ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FrancescoDippolitoAndMariaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
