using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_01 : CardInfo
{
    public CardInfo_015_JA_01()
    {
        this.cardNo = "015_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミスター・スミー";
        this.cardName2 = "忠実な一等航海士";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Kamil Murzyn / Eri Well";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
