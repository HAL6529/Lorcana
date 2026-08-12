using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_01 : CardInfo
{
    public CardInfo_092_JA_01()
    {
        this.cardNo = "092_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "タマトア";
        this.cardName2 = "ダサガニ";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Jeff Murchie";
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
