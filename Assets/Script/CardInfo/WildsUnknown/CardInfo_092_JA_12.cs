using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_12 : CardInfo
{
    public CardInfo_092_JA_12()
    {
        this.cardNo = "092_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クルエラ";
        this.cardName2 = "ダメ出しの旅人";
        this.power = 4;
        this.toughness = 4;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
