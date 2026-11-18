using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_210_JA_08 : CardInfo
{
    public CardInfo_210_JA_08()
    {
        this.cardNo = "210_JA_08";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "クスコ";
        this.cardName2 = "衝動的なラマ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
