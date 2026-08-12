using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_01 : CardInfo
{
    public CardInfo_076_JA_01()
    {
        this.cardNo = "076_JA_01";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ジーニー";
        this.cardName2 = "パワー全開";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = "Javier Salas";
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
