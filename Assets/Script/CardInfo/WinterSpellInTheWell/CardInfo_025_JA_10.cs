using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_10 : CardInfo
{
    public CardInfo_025_JA_10()
    {
        this.cardNo = "025_JA_10";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ガゼル";
        this.cardName2 = "バラードの歌姫";
        this.power = 3;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CelesteJamneck;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer7 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
