using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_01 : CardInfo
{
    public CardInfo_047_JA_01()
    {
        this.cardNo = "047_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "魔法のほうき";
        this.cardName2 = "バケツリレー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Dav Augereau / Giulia Riva";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
